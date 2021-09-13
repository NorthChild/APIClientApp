using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace APIClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // get request // 
            // setup single postcode request //
            ////// create a client property which is equal to a new restSharp
            ////// we are going to create a Uri obj which encapsulates
            ////var restClient = new RestClient(@"https://api.postcodes.io/");

            ////// set up request
            ////var restRequest = new RestRequest();
            ////restRequest.Method = Method.GET;
            ////// header info
            ////restRequest.AddHeader("Content-Type", "application/json");
            ////// set time out
            ////restRequest.Timeout = -1;
            ////var postCode = "EC2Y 5AS";

            ////// define request resource path
            ////restRequest.Resource = $"postcodes/{postCode.ToLower().Replace(" ", "")}";

            //// EXECUTE REQUEST //
            //var singlePostcodeResponse = restClient.Execute(restRequest);
            ////Console.WriteLine("Response Content as string");
            ////Console.WriteLine(singlePostcodeResponse.Content);



            //// set up bulkpostcode request // 
            //var client = new RestClient(@"https://api.postcodes.io/postcodes/");
            //client.Timeout = -1;
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Content-Type", "application/json");

            //// post request // 
            //JObject postCodes = new JObject
            //{
            //    new JProperty("postcodes", new JArray(new string[] {"OX49 5NU", "M32 0JG", "NE30 1DP" }))
            //};


            //request.AddParameter("application/json", postCodes.ToString(), ParameterType.RequestBody);
            //request.AddJsonBody(postCodes.ToString());

            //IRestResponse bulkPostcodeResponse = await client.ExecuteAsync(request);
            //Console.WriteLine(bulkPostcodeResponse.Content);
            //Console.WriteLine($"STATUS CODE {bulkPostcodeResponse.StatusCode}");
            //Console.WriteLine($"STATUS CODE {(int)bulkPostcodeResponse.StatusCode}");


            // example of JObject
            //var course = new JObject
            //{
            //    new JProperty("name", "eng91"),
            //    new JProperty("trainees", new JArray(new string[] {"Ringo", "John", "Paul" })),
            //    new JProperty("total", 4)
            //};

            // QUERY OUR RESPONSE AS A JOBJECT //

            //var bulkJsonResponse = JObject.Parse(bulkPostcodeResponse.Content);
            //var singleJsonResponse = JObject.Parse(singlePostcodeResponse.Content);
            //Console.WriteLine(singleJsonResponse["status"]);
            //Console.WriteLine(singleJsonResponse["result"]["country"]);
            //Console.WriteLine(singleJsonResponse["result"]["codes"]["parish"]);

            //Console.WriteLine(bulkJsonResponse["result"][0]["query"]);
            //Console.WriteLine(bulkJsonResponse["result"][1]["result"]["country"]);


            // QUERY OUR RESPONSE AS A C# OBJECT // 
            ////var singlePostCode = JsonConvert.DeserializeObject<SinglePostcodeResponse>(singlePostcodeResponse.Content);
            ////var bulkPostCode = JsonConvert.DeserializeObject<BulkPostcodeResponse>(bulkPostcodeResponse.Content);

            //Console.WriteLine(singlePostCode.result.country);
            //Console.WriteLine(singlePostCode.result.codes.admin_county);

            //foreach (var result in bulkPostCode.result)
            //{
            //    Console.WriteLine(result.query);
            //    Console.WriteLine(result.postcode.region);
            //}


            //var result2 = bulkPostCode.result.Where(c => c.query == "OX49 5NU").Select(p => p.postcode.parish).FirstOrDefault();
            //Console.WriteLine(result2);


            //// set up
            //var newRequest = new RestRequest();
            //var postCode2 = "SM4";
            //newRequest.Resource = $"outcodes/{postCode2.ToLower().Replace(" ", "")}";

            //// execute
            //var outCodeResponse = restClient.Execute(newRequest);

            //// query 
            //var OutCodeQuery = JsonConvert.DeserializeObject<OutcodeResponse>(outCodeResponse.Content);

            //// display
            //Console.WriteLine(OutCodeQuery.result);



            //var client2 = new RestClient(@"https://api.postcodes.io/outcodes/SM4");
            //client2.Timeout = -1;

            //var request2 = new RestRequest(Method.GET);

            //IRestResponse response = client2.Execute(request2);

            //var outCodeJsonResponse = JObject.Parse(singlePostcodeResponse.Content);

            //Console.WriteLine(outCodeJsonResponse["result"]);

            RestClient outClient = new RestClient(@"https://api.postcodes.io/outcodes/AL1");
            outClient.Timeout = -1;
            RestRequest outRequest = new RestRequest(Method.GET);
            IRestResponse outResponse = outClient.Execute(outRequest);

            //var outDetails = JsonConvert.DeserializeObject<OutCodeResponse>(outResponse.Content);

            //Console.WriteLine(outDetails.status);
            //foreach (var parish in outDetails.result.parish)
            //{
            //    Console.WriteLine(parish);
            //}
            //bool result = outDetails.result.admin_ward.Where(o => o.Contains("Colney")).Select(o => o.Contains("Colney")).FirstOrDefault();
            //Console.WriteLine(result);

        }
    }
}