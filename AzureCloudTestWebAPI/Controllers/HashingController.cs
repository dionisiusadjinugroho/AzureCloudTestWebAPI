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
    public class HashingController : ControllerBase
    {
        private IHashingService _hashingService;
        public HashingController(IHashingService hashingService)
        {
            _hashingService = hashingService;
        }

        //// GET: api/<HashingController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        /// <summary>
        /// Get Hash
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<HashingController>/5
        [HttpGet("{id}")]
        public Hashing Get(string id)
        {
            return _hashingService.MD5Hashing(id);
        }

        //// POST api/<HashingController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<HashingController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<HashingController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
