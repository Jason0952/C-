using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Candidate
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}