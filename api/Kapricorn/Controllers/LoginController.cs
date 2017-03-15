using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace Kapricorn.Controllers
{
    public class LoginController : ApiController
    {
        public MongoClient mClient = null;
        public MongoServer globalserver = null;
        public MongoDatabase dbMongo = null;
        public string s_Database;
        public string s_Collection;

        [HttpPost]
        public HttpResponseMessage SendData(UserInfo userinfo, HttpRequestMessage request)
        {
            //TBA
            string s_hack_db = System.Configuration.ConfigurationManager.AppSettings["hackstore"];

            GetDB db = new GetDB();
            db.GetSystemDatabase(s_hack_db, "hack_SvyApp", ref dbMongo, ref s_Database, ref s_Collection);


            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{{\"success\":\"{0}\", \"userid\":\"{1}\"}}", 1, 12);
            var resp = new HttpResponseMessage { Content = new StringContent(sb.ToString(), System.Text.Encoding.UTF8, "application/json") };
            return resp;
        }
    }
}
