using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using isRock.Framework;
using isRock.Framework.WebAPI;
using Newtonsoft.Json;

namespace Activity.Controllers
{
    public class ExampleController : ApiController
    {
        [Route("api/Action/{ChangeJSONFile}")]
        [HttpPost]
        public IHttpActionResult ExecuteMethod(string ChangeJSONFile)
        {
            try
            {
                //AssemblyLauncher
                AssemblyLauncher assemblyLauncher = new AssemblyLauncher();
                //執行指定的Method
                var ret = assemblyLauncher.ExecuteCommand<Change>(
                    new Change(),
                    ChangeJSONFile,
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

    //回傳顯示出來的值
    public class ReturnJSON
    {
        public string JSONFile { get; set; }
    }

    //傳入的屬性
    public class ChangeJSON
    {
        public string username { get; set; }
    }

    public class userjson
    {
        public object DataFields { get; set; }
        public Activity[] Activities { get; set; }
    }

    public class Activity
    {
        public string KBID { get; set; }
        public string EndpointKey { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public object PrecedingRule { get; set; }
        public object Tasks { get; set; }
        public string ResponseMessage { get; set; }
    }

    //繼承 BusinessLogicBase
    public class Change : BusinessLogicBase
    {       
        public ExecuteCommandDefaultResult ChangeActivity()
        {
            var db = new JSONFileDataContext();

            var jsondb = from json in db.JSON_Table
                         where json.JSONID == 1
                         select json.JSON;

            return new ExecuteCommandDefaultResult
            {
                Data = new ReturnJSON() { JSONFile = jsondb.ToString() },
                isSuccess = true,
                Message = "沒有填入名字"
            };
        }
    }
}
