using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrderSystemWeb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
namespace OrderSystemWebTest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void ValidIndexTest()
        {
            var controller = new HomeController();
            var result = controller.Index();
            var viewResult = result as ViewResult;
            var viewName = viewResult.ViewName;
            var message = (string)viewResult.ViewBag.Message;
            var expectedMessage = "Welcome to Kotacs Order System";

            Assert.IsNotNull(viewResult, "Expected View Result Not Valid!");
            Assert.AreEqual<string>(string.Empty, viewName, "Expected View Name Not Valid!");
            Assert.AreEqual<string>(expectedMessage, message, "Expected Message Not Found / Valid!");
        }

        [TestMethod]
        public void ValidProcessTestWithMocking()
        {
            var mockRepository = new MockRepository(MockBehavior.Default);
            var mockHttpContext = mockRepository.Create<HttpContextBase>();

            var mockHttpRequest = mockRepository.Create<HttpRequestBase>();
            mockHttpContext.Setup(context => context.Request).Returns(mockHttpRequest.Object);

            var mockHttpResonse = mockRepository.Create<HttpResponseBase>();
            mockHttpContext.Setup(context => context.Response).Returns(mockHttpResonse.Object);

            var responseCookies = new HttpCookieCollection();
            mockHttpResonse.Setup(response => response.Cookies).Returns(responseCookies);

            var id = "C100011";
            var controller = new HomeController();
            var controllerContext = new ControllerContext(
                mockHttpContext.Object, new RouteData(), controller);

            controller.ControllerContext = controllerContext;

            var result = controller.Process(id) as ViewResult;
            var actualCookie = responseCookies[COOKIE_NAME];

            Assert.IsNotNull(result, "View Result Not Valid!");
            Assert.AreEqual<string>(string.Empty, result.ViewName, "View Name Not Valid!");
            Assert.AreEqual<string>(expected: id,
                actual: actualCookie.Value, message: "Expected Cookie Value Not Valid!");
        }

        private const string COOKIE_NAME = "Thomson.Cookie";
    }
}
