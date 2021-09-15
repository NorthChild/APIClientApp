using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APITestApp.PostcodesIOService
{
    // Constraints specify that the DTO can only be of IResponse type AND specifies the new() that a type argument is a generic class declaration MUST have a public prameterless constructor

    public class DTO<ResponseType> where ResponseType : IResponse, new()
    {
        // a property which represents the model
        public ResponseType Response { get; set; }

        // method that creates above obj using the response from the API
        public void DeserializeResponse(string postcodeResponse)
        {
            Response = JsonConvert.DeserializeObject<ResponseType>(postcodeResponse);
        }
    }
}

