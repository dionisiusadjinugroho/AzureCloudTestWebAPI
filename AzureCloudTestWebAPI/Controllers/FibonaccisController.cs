using AzureCloudTestWebAPI.Models;
using AzureCloudTestWebAPI.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AzureCloudTestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonaccisController : ControllerBase
    {
        private IFibonacciService _fibonacciService;
        public FibonaccisController(IFibonacciService fibonacciService)
        {
            _fibonacciService = fibonacciService;
        }

        //// GET: api/<FibonaccisController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<FibonaccisController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<FibonaccisController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        /// <summary>
        /// Get Fibonacci Sequence from n -> to m Refer to https://www.calculatorsoup.com/calculators/discretemathematics/fibonacci-calculator.php
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        // POST api/Fibonaccis/GetFibonacciSequence
        [HttpPost("GetSequence")]
        public IActionResult GetFibonacciSequence([FromBody] FibonacciInput value)
        {
            var result = _fibonacciService.FibonacciSequence(value.From, value.To);
            return Ok(result);
        }

        //// PUT api/<FibonaccisController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<FibonaccisController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
