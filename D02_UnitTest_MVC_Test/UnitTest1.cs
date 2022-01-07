using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using D02_UnitTest_MVC_Client.Controllers;

namespace D02_UnitTest_MVC_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AboutAction_ShouldReturnAboutView_Error()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("About", result.ViewName);

        }
    }
}
