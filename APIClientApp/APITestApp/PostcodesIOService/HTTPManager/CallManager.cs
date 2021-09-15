using APIClientApp;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.PostcodesIOService
{
    public class CallManager
    {

        // restsharp object which handles comms with the api
        private readonly IRestClient _client;

        // capture status 
        public int StatusCode { get; set; }

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        /// <summary>
        /// define and makes the api request and stores the response
        /// </summary>
        /// <param name="postcode"></param>
        public async Task<string> MakePostcodeRequestAsync(string postcode)
        {
            // set up request
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");

            // define request resource path
            request.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";

            // make the request
            IRestResponse response = await _client.ExecuteAsync(request);

            StatusCode = (int)response.StatusCode;

            return response.Content;
        }
    }
}
