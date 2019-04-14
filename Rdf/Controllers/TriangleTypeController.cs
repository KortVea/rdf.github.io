using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Rdf.Models;

namespace Rdf.Controllers
{
    public class TriangleTypeController : ApiController
    {
        public string Get(double a, double b, double c)
        {
            var tri = new Triangle { a = a, b = b, c = c };
            return tri.GetTriangleType();
        }
    }
}
