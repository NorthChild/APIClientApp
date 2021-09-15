using System;
using APIClientApp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Threading.Tasks;
using APIClientApp;
using APITestApp;
using APITestApp.PostcodesIOService;


namespace APITestApp.PostcodeIOService
{
    public class SinglePostCodeService
    {
        #region Properties

        public CallManager CallManager { get; set; }
        public JObject Json_Response { get; set; }

        // response Data Transfer Object
        public DTO<SinglePostcodeResponse> SinglePostcodeDTO { get; set; }

        // postcode used in the API request

        public string PostcodeSelected { get; set; }
        public string PostcodeResponse { get; set; }

        #endregion


        // create construnctor, create rest client obj
        public SinglePostCodeService()
        {
            CallManager = new CallManager();
            SinglePostcodeDTO = new DTO<SinglePostcodeResponse>();
        }


        public async Task MakeRequestAsync(string postcode)
        {
            // set property
            PostcodeSelected = postcode;

            //// make the request
            PostcodeResponse = await CallManager.MakePostcodeRequestAsync(postcode);

            // Parse Json in response content
            Json_Response = JObject.Parse(PostcodeResponse);

            // use DTO to convert JSON string into and object tree
            SinglePostcodeDTO.DeserializeResponse(PostcodeResponse);
            

        }
    }
}
