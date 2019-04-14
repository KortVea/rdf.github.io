using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rdf.Controllers
{
    public class ReverseWordsController : ApiController
    {
        public string Get(string sentence)
        {
            var charArray = sentence.ToCharArray().Reverse().ToArray();
            return new string(charArray);
        }
    }
}
