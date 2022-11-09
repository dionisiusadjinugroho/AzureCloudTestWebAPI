using Microsoft.VisualStudio.TestTools.UnitTesting;
using AzureCloudTestWebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using AzureCloudTestWebAPI.Service;
using AzureCloudTestWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureCloudTestWebAPI.Controllers.Tests
{
    [TestClass()]
    public class TrianglesControllerTests
    {

        [TestMethod()]
        public void PostTest()
        {
            var testdata = new TriangleSides()
            {
                A = 3,
                B = 3,
                C = 3
            };

            var mockRepo = new TriangleService();
            var controller = new TrianglesController(mockRepo);

            var actionresult = controller.Post(testdata);
            var result = actionresult as OkObjectResult;
            var resultstring = result.Value.ToString();

            var expectedstring = "Equilateral Triangle";
            //Assert
            Assert.AreEqual(resultstring, expectedstring);
        }
    }
}