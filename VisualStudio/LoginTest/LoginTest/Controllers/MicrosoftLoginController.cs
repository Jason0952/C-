using LoginTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace LoginTest.Controllers
{
    public class MicrosoftLoginController : ApiController
    {
        [ActionName("getcode")]
        [HttpPost]
        public IHttpActionResult GetToken(string code)
        {
            StringContent Contentcode = new StringContent(code); //提供以字串為基礎的Http內容
            var client = new HttpClient(); //發送request出去的行為
            var access_token = client.PostAsync("https://login.microsoftonline.com/common/oauth2/v2.0/token", Contentcode).Result; //抓整個回應 //result讓postasync(非同步)強迫同步
            var checktoken = access_token.Content.ReadAsStringAsync().Result; //抓到respone的body  == Postman中所有的回應(Body、Cookie、Headers、TestResult)
            var accesstokenjson = JsonConvert.DeserializeObject<accesstoken>(checktoken); //反序列化(從json轉class類別)
            var accesstoken = accesstokenjson.access_token;
            return Ok(accesstoken);
        }

        [ActionName("accesstoken")]
        [HttpPost]
        public IHttpActionResult GetUserdata(string accesstoken)
        {
            StringContent TokenContent = new StringContent(accesstoken);
            var client = new HttpClient();
            var Userdata = client.GetAsync("https://graph.microsoft.com/beta/me").Result;
            var checktoken = Userdata.Content.ReadAsStringAsync().Result;
            var getuserdata = JsonConvert.DeserializeObject<userjson>(checktoken);
            List<string> userinfo = new List<string> { getuserdata.userPrincipalName, getuserdata.displayName };
            return Ok(userinfo);
        }
        

    }
}
