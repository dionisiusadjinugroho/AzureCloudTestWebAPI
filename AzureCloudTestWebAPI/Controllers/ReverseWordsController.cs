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
    public class ReverseWordsController : ControllerBase
    {
        private IReverseService _reverseService;
        public ReverseWordsController(IReverseService reverseService)
        {
            _reverseService = reverseService;
        }
        //// GET: api/<ReverseWordsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        /// <summary>
        /// Get Reverse Word
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<ReverseWordsController>/Test
        [HttpGet("{id}")]
        public string Get(string id)
        {
            string reverseResult = _reverseService.Reverse(id);
            return reverseResult;
        }

        //// POST api/<ReverseWordsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ReverseWordsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ReverseWordsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
