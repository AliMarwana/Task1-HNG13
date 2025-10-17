<h2>This project is an API which has an endpoint returning specific data. It's a required project For Backend in HNG 13.</h2>
This data contains also text from a third party API which is Cat Facts API. 
Here is the format of the data: 
{status: string,
user:{
email:string,
name: string,
stack:  string
},
timestamp: current UTC time ISO 8601,
"fact": "<random cat fact from Cat Facts API>"}. 
The link of the API to access the data is:https://task1-hng13-production.up.railway.app/me.
The data contains the user credentials, the stack I used for this API. I added also the timestamp which is the time the request has been done.
Fact property contains the data fetched from Cat Facts API.

