using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using APITestApp.Services;
using System.Threading.Tasks;

namespace APITestApp.Tests___Sad
{
    public class WhenBulkPostcodeIsCalledWithInvalidPostCodes
    {
        private BulkPostcodeService _bulkPostcodeResponse;

        [OneTimeSetUp]
        public async Task OneTimeSetup()
        {
            _bulkPostcodeResponse = new BulkPostcodeService();
            await _bulkPostcodeResponse.MakeRequestAsync(new string[] { "123", "OtherNot" });
        }
        [Test]
        public void StatusIs404()
        {
            Assert.That(_bulkPostcodeResponse.ResponseContent["status"].ToString(), Is.EqualTo("404"));
        }
    }
}
