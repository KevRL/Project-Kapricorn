using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;

namespace Kapricorn.Controllers
{
    public class LoginController : ApiController
    {
        public HttpResponseMessage SendData(UserInfo uInfo, HttpRequestMessage request)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{{\"success\":\"{0}\", \"userid\":\"{1}\"}}", 1, 12);
            var resp = new HttpResponseMessage { Content = new StringContent(sb.ToString(), System.Text.Encoding.UTF8, "application/json") };
            return resp;
        }
    }
}
