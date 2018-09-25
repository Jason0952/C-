using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginTest.Models
{
    public class userjson
    {
        public string odatacontext { get; set; }
        public string displayName { get; set; }
        public object surname { get; set; }
        public object givenName { get; set; }
        public string id { get; set; }
        public string userPrincipalName { get; set; }
        public object[] businessPhones { get; set; }
        public object jobTitle { get; set; }
        public object mail { get; set; }
        public object mobilePhone { get; set; }
        public object officeLocation { get; set; }
        public object preferredLanguage { get; set; }
    }
}