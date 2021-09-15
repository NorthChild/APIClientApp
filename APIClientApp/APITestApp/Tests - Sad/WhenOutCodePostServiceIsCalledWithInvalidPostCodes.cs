//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using APITestApp.Services;

//namespace APITestApp.Tests___Sad
//{
//    public class WhenOutCodePostServiceIsCalledWithInvalidPostCodes
//    {

//        private OutPostCodeService _outPostCodeService;
//        [OneTimeSetUp]
//        public async Task OneTimeSetup()
//        {
//            _outPostCodeService = new OutPostCodeService();
//            await _outPostCodeService.MakeRequestAsync("XYZ");
//        }
//        [Test]
//        public void StatusIs404()
//        {
//            Assert.That(_outPostCodeService.ResponseContent["status"].ToString(), Is.EqualTo("404"));
//        }
//    }
//}
