using Microsoft.VisualStudio.TestTools.UnitTesting;
using AzureCloudTestWebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using AzureCloudTestWebAPI.Service;
using Newtonsoft.Json;
using AzureCloudTestWebAPI.Models;

namespace AzureCloudTestWebAPI.Controllers.Tests
{
    [TestClass()]
    public class HashingControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            var testdata = "testing";

            var mockRepo = new HashingService();
            var controller = new HashingController(mockRepo);

            var result = controller.Get(testdata);

            var resultstring = JsonConvert.SerializeObject(result);

            var expected = new Hashing() {
                Algorithm = "MD5",
                Value = "risfylFZSeXVT7IrjtlVdQ=="
            };
            var expectedstring = JsonConvert.SerializeObject(expected);
            //Assert
            Assert.AreEqual(resultstring, expectedstring);
        }
    }
}