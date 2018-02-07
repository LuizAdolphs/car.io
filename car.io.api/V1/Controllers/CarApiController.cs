using car.io;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car.io.api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{ver:apiVersion}/[controller]")]
    public class CarApiController : Controller
    {
        /// <summary>
        /// Return cars by name
        /// </summary>
        /// <remarks>Returns a map of cars by name using like operation</remarks>
        /// <param name="carName">Partial name of the cars to return</param>
        /// <response code="200">successful operation</response>
        [HttpGet]
        [Route("name/{carName}")]
        public virtual IActionResult GetCarByName([FromRoute]string carName)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Car>(exampleJson)
            : default(Car);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Find pet car ID
        /// </summary>
        /// <remarks>Returns a single car</remarks>
        /// <param name="carId">ID of car to return</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Car not found</response>
        [HttpGet]
        [Route("{carId}")]
        public virtual IActionResult GetCarById([FromRoute]long? carId)
        { 
            var example = new Car();

            return new ObjectResult(example);
        }
    }
}
