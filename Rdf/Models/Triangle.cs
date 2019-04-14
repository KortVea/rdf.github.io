using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rdf.Models
{
    public class Triangle
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public bool IsValidated => (a + b > c) && (b + c > a) && (c + a > b);

        public string GetTriangleType()
        {
            if (a == 0 || b == 0 || c == 0 || !IsValidated)
            {
                return "Error";
            }
            else if (a == b && b == c)
            {
                return "Equilateral";
            }
            else if (a == b || b == c || c == a)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }

        }
    }
}