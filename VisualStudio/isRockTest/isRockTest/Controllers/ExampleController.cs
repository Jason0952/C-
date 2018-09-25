using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using isRock.Framework;
using isRock.Framework.WebAPI;
using Newtonsoft.Json;

namespace isRockTest.Controllers
{
    public class ExampleController : ApiController
    {
        [Route("api/Action/{GetToken}")]
        [HttpPost]
        public IHttpActionResult Getcode(string GetToken)
        {
            try
            {
                //AssemblyLauncher
                AssemblyLauncher assemblyLauncher = new AssemblyLauncher();
                //執行指定的Method
                var ret = assemblyLauncher.ExecuteCommand<GetToken>(
                    new GetToken(),
                    GetToken,
                    Request.Content.ReadAsStringAsync().Result);
                //回傳OK
                return Ok(ret);
            }
            catch (Exception ex)
            {
                //其他處理
                throw ex;
            }
        }
    }

    //回傳html
    public class returnuserdata
    {
        public string userdata { get; set; }
    }
    //傳入service
    public class getCode
    {
        public string Code { get; set; }
    }

    public class usertoken
    {
        public string token_type { get; set; }
        public string scope { get; set; }
        public int expires_in { get; set; }
        public int ext_expires_in { get; set; }
        public string access_token { get; set; }
        public string id_token { get; set; }
    }


    public class UserData
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

    public class GetToken : BusinessLogicBase
    {
        public ExecuteCommandDefaultResult UserToken(getCode MyCode)
        {
            //用Code換Token
            var Content = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string, string>("client_id","4f8961e9-ebec-46d7-8fde-7a4ea6680bae"),
                new KeyValuePair<string, string>("code",MyCode.Code),
                new KeyValuePair<string, string>("redirect_uri","http://localhost:56954/Sample.html"),
                new KeyValuePair<string, string>("grant_type","authorization_code"),
                new KeyValuePair<string, string>("client_secret","vmscQ3854[:)qjrTEZIMA4$")
            });  //放入postman的body裡面的所有對應值

            var client = new HttpClient();
            var accesstoken = client.PostAsync("https://login.microsoftonline.com/common/oauth2/v2.0/token", Content).Result; //抓整個回應 //result讓postasync(非同步)強迫同步
            var checktoken = accesstoken.Content.ReadAsStringAsync().Result; //抓到respone的body  == Postman中所有的回應(Body、Cookie、Headers、TestResult)
            var accesstokenjson = JsonConvert.DeserializeObject<usertoken>(checktoken); //反序列化(從json轉class類別)
            var access_token = accesstokenjson.access_token;

            //使用Token換UserData            
            //StringContent authorize = new StringContent(access_token);
            //var userjson = client.GetAsync("https://graph.microsoft.com/beta/me", null, authorize).Result;
            //var checkuserjson = userjson.Content.ReadAsStringAsync().Result;
            //var userdata = JsonConvert.DeserializeObject<UserData>(checktoken);
            //var UserName = userdata.displayName;
            

            return new ExecuteCommandDefaultResult
            {
                Data = access_token,
                isSuccess = true,
                Message = "未抓到code"
            };
        }
    }
}
