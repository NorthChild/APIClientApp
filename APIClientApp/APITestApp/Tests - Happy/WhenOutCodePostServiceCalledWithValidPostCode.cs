using NUnit.Framework;
using APITestApp.Services;
using System.Threading.Tasks;

namespace APITestApp.Tests
{
    class WhenTheOutPostcodeServiceIsCalledWithValidOutwardCode
    {
        private OutPostCodeService _OutPostcodeService;
        
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _OutPostcodeService = new OutPostCodeService();
            _OutPostcodeService.MakeRequestAsync("SM4");
        }


        [Test]
        public void StatusIs200()
        {
            Assert.That(_OutPostcodeService.StatusCode, Is.EqualTo(200));
        }
        [Test]
        public void OutcodeIsCorrect()
        {
            var result = _OutPostcodeService.ResponseObject.result.outcode;
            Assert.That(result, Is.EqualTo("SM4"));
        }
    }
}
