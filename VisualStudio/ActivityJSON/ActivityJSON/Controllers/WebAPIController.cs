using ActivityJSON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ActivityJSON.Controllers
{
    public class WebAPIController : ApiController
    {
        public static List<MemberModel> GetAllMember()
        {
            MyLinqtoSQLDataContext db = new MyLinqtoSQLDataContext();
            List<MemberModel> Members = new List<MemberModel>();
            var members = db.Member;
            foreach (var memberinfo in members)
            {
                Members.Add(new MemberModel { ID = memberinfo.ID, Name = memberinfo.Name, Cellphone = memberinfo.Cellphone });
            }

            return Members;
        }
    }
}
