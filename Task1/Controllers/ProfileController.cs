using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Net.Http;
using System.Text.Json;
using Task1.Models;
using Task1.Repositories;

namespace Task1.Controllers
{
    [Route("me")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        ProfileRepository _profileRepository;
        private readonly IHttpClientFactory _httpClientFactory;

        public ProfileController(ProfileRepository profileRepository, IHttpClientFactory httpClientFactory)
        {
            _profileRepository = profileRepository;
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> GetProfileInfo()
        {
            try
            {
                InfoModel model = new InfoModel();
                model = _profileRepository.GetPersonalInfo();
                model.Timestamp = DateTime.Now;
                var client = _httpClientFactory.CreateClient();
                var response = await client.GetAsync("https://catfact.ninja/fact");


                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    using JsonDocument document = JsonDocument.Parse(content);
                    JsonElement root = document.RootElement;

                    // Get top-level properties
                    string fact = root.GetProperty("fact").GetString();
                    model.Fact = fact;
                    return Ok(model);
                }
                else
                {
                    return BadRequest("the fact value is not available"); 
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Not found information");
            }
            
        }
    }
}
