using Microsoft.VisualStudio.TestTools.UnitTesting;
using AzureCloudTestWebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using AzureCloudTestWebAPI.Service;
using Newtonsoft.Json;

namespace AzureCloudTestWebAPI.Controllers.Tests
{
    [TestClass()]
    public class ReverseWordsControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            var testdata = "Yogi";

            var mockRepo = new ReverseService();
            var controller = new ReverseWordsController(mockRepo);

            var result = controller.Get(testdata);

            var expected = "igoY";
            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}