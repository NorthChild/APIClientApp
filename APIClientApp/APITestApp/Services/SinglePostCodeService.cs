using System;
using APIClientApp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Threading.Tasks;

namespace APITestApp.Services
{
    public class SinglePostCodeService
    {
        #region Properties

        //RestSharp Object which handles comms with the API
        public RestClient Client;
        
        // a newtonsoft object representing the json response
        public JObject ResponseContent { get; set; }

        // the postcode used in this API request
        public string PostcodeSelected { get; set; }

        // store status code
        public int StatusCode { get; set; }

        // an object model of the response 
        public SinglePostcodeResponse ResponseObject { get; set; }
        #endregion

        // create construnctor, create rest client obj
        public SinglePostCodeService()
        {
            Client = new RestClient { BaseUrl = new Uri(AppConfigReader.BaseUrl) };
        }

        public async Task MakeRequestAsync(string postcode)
        {
            // set up request
            var request = new RestRequest();

            // add header
            request.AddHeader("Content-Type", "application/json");

            // set property
            PostcodeSelected = postcode;

            //define resource path
            request.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";

            // make the request
            IRestResponse response = await Client.ExecuteAsync(request);

            // Parse Json in response content
            ResponseContent = JObject.Parse(response.Content);

            // capture status code
            StatusCode = (int)response.StatusCode;
            
            // Parse json into an object tree
            ResponseObject = JsonConvert.DeserializeObject<SinglePostcodeResponse>(response.Content);
        }
    }
}
