using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Rdf.Models;

namespace Rdf.Controllers
{
    public class FibonacciController : ApiController
    {
        public IHttpActionResult Get(int n)
        {
            try
            {
                var result = new Fibonacci(n).GetNth(n);
                return Ok(result);
            }
            catch (OverflowException)
            {
                return BadRequest();
            }
            
        }
    }
}
