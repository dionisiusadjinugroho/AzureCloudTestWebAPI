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
    public class TrianglesController : ControllerBase
    {
        private ITriangleService _triangleService;
        public TrianglesController(ITriangleService triangleService)
        {
            _triangleService = triangleService;
        }

        //// GET: api/<TrianglesController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<TrianglesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        /// <summary>
        /// Get Category of Triangles -> Refer logic to Triangle https://www.calculator.net/triangle-calculator.html
        /// </summary>
        /// <param name="trsides"></param>
        /// <returns></returns>
        // POST api/Triangles/GetCategory
        [HttpPost("GetCategory")]
        public IActionResult Post([FromBody] TriangleSides trsides)
        {
            var Categoryresult = _triangleService.GetCategoryTriangle(trsides.A, trsides.B, trsides.C);
            return Ok(Categoryresult);
        }

        //// PUT api/<TrianglesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<TrianglesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
