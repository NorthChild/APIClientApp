//using System;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using RestSharp;
//using APIClientApp;
//using System.Threading.Tasks;

//namespace APITestApp.PostcodeIOService
//{
//    public class OutPostCodeService
//    {
//        #region Properties
//        public RestClient Client;
//        public JObject ResponseContent { get; set; }
//        public string OutwardCode { get; set; }
//        public int StatusCode { get; set; }
//        public OutCodeResponse ResponseObject { get; set; }
//        #endregion

//        public OutPostCodeService()
//        {
//            Client = new RestClient { BaseUrl = new Uri(AppConfigReader.BaseUrl) };
//        }

//        public async Task MakeRequestAsync(string outcode)
//        {
//            var request = new RestRequest(Method.GET);

//            request.AddHeader("Content-Type", "application/json");
//            request.Resource = $"/outcodes/{outcode}";
//            OutwardCode = outcode;

//            IRestResponse response = Client.Execute(request);

//            ResponseContent = JObject.Parse(response.Content);
//            StatusCode = (int)response.StatusCode;

//            ResponseObject = JsonConvert.DeserializeObject<OutCodeResponse>(response.Content);
//        }
//    }
//}
