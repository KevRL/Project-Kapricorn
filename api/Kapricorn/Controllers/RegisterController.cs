using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MongoDB.Bson;
using MongoDB.Driver;
//using Newtonsoft.Json;

namespace Kapricorn.Controllers
{
        public class RegisterController : ApiController
    {
        public HttpResponseMessage GetData()
        {
            string json = "[{\"GetData\":\"RWH\"}]";
            var respx = new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
            return respx;
        }

        [HttpPost]
        public HttpResponseMessage GetLogin(string name_id, string email_id, string pswd_id)
        {
            string json = "[{\"name\":\"" + name_id + "\"}, {\"email\":\"" + email_id + "\"}, {\"pswd\":\"" + pswd_id + "\"}]";
            var respx = new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
            return respx;
        }

    }
}