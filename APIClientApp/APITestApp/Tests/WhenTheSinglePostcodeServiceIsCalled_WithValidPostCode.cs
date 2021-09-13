using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using APITestApp.Services;
using System.Threading.Tasks;

namespace APITestApp.Tests
{
    public class WhenTheSinglePostcodeServiceIsCalled_WithValidPostCode
    {

        private SinglePostCodeService _singlePostCodeService;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _singlePostCodeService = new SinglePostCodeService();
            await _singlePostCodeService.MakeRequestAsync("EC2Y 5AS");
        }

        [Test]
        public void StatusIs200()
        {
            Assert.That(_singlePostCodeService.ResponseContent["status"].ToString(), Is.EqualTo("200"));
        }

        [Test]
        public void StatusIs200_Alternative()
        {
            Assert.That(_singlePostCodeService.StatusCode, Is.EqualTo(200));
        }

        [Test]
        public void CorrectPostCodeIsReturned()
        {
            var result = _singlePostCodeService.ResponseContent["result"]["postcode"].ToString();
            Assert.That(result, Is.EqualTo("EC2Y 5AS"));
        }



    }
}
  