using Task1.Models;

namespace Task1.Repositories
{
    public class ProfileRepository
    {
        

        public InfoModel GetPersonalInfo()
        {
            InfoModel info = new InfoModel();
            info = new InfoModel
            {
                User = new User
                {
                    Email = "ali.marwanaabdou@etu.uae.ac.ma",
                    Name = "Ali Marwana Abdou",
                    Stack = "C#/ASP.NET Core Web API"
                },
                Status = "success"

            };
            return info;

        }
    }
}
