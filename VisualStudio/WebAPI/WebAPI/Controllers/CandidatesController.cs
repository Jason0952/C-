using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class CandidatesController : ApiController
    {
        private Models.Candidate[] Candidates = new Models.Candidate[]
        {
            new Models.Candidate{ Name="Peter", ID="1", Age=20, Email="Peter@gamil.com" },
            new Models.Candidate{ Name="John", ID="2", Age=22, Email="John@gamil.com" },
            new Models.Candidate{ Name="Jason", ID="3", Age=25, Email="Jason@gamil.com" }
        };
               //IEnumerable代表一個資料集
        public IEnumerable<Models.Candidate> GetAllCandidates()
        {
            return Candidates;
        }

        //取得特定名稱應徵者的資料
               //IHttpActionResult代表Http一個狀態
        public IHttpActionResult GetCandidate(string Name)
        {
            var myCandidate = Candidates.FirstOrDefault((c) => c.Name == Name);
            if (myCandidate == null)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return Ok(myCandidate);
        }
    }
}
