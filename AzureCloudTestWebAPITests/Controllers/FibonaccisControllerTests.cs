using Microsoft.VisualStudio.TestTools.UnitTesting;
using AzureCloudTestWebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using AzureCloudTestWebAPI.Service;
using AzureCloudTestWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AzureCloudTestWebAPI.Controllers.Tests
{
    [TestClass()]
    public class FibonaccisControllerTests
    {

        [TestMethod()]
        public void GetFibonacciSequenceTest()
        {
            var testdata = new FibonacciInput() { From = 1, To = 3 };

            var mockRepo = new FibonacciService();
            var controller = new FibonaccisController(mockRepo);

            var actionresult = controller.GetFibonacciSequence(testdata);
            var result = actionresult as OkObjectResult;
            
            var resultstring = JsonConvert.SerializeObject(result.Value);

            var expected = new List<Fibonacci>() {
                new Fibonacci() { Fn = "1", Number = 1 },
                new Fibonacci() { Fn = "2", Number = 1 },
                new Fibonacci() { Fn = "3", Number = 2 }
            };
            var expectedstring = JsonConvert.SerializeObject(expected);
            //Assert
            Assert.AreEqual(resultstring, expectedstring);
        }
    }
}