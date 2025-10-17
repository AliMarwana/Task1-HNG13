<h2>This project is an API which has an endpoint returning specific data. It's a required project For Backend in HNG 13.</h2>
<h3>This data contains also text from a third party API which is Cat Facts API. </h3>
<h3>Here is the format of the data: </h3>

{status: string,<br>
user:{ <br>
email:string, <br>
name: string, <br>
stack:  string <br>
}, <br>
timestamp: current UTC time ISO 8601,<br>
"fact": "<random cat fact from Cat Facts API>"}. <br>
<p>The link of the API to access the data is:https://task1-hng13-production.up.railway.app/me.</p>
<p>
The data contains the user credentials, the stack I used for this API. I added also the timestamp which is the time the request has been done.
Fact property contains the data fetched from Cat Facts API.
</p>

