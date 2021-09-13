using NUnit.Framework;
using APITestApp.Services;
using System.Threading.Tasks;

namespace APITestApp.Test___Sad
{
    public class WhenTheSinglePostcodeServiceIsCalledWithInvalidPostCode
    {
        private SinglePostCodeService _singlePostcodeService;
        [OneTimeSetUp]
        public async Task OneTimeSetup()
        {
            _singlePostcodeService = new SinglePostCodeService();
            await _singlePostcodeService.MakeRequestAsync("Not Found");
        }
        [Test]
        public void StatusIs404()
        {
            Assert.That(_singlePostcodeService.StatusCode, Is.EqualTo(404));
        }
    }
}
