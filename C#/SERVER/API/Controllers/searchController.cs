using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]//any localhost can connect to C#
    [RoutePrefix("api/Search")]//the url in google
    public class SearchController : ApiController
    {
        [ActionName("SaveSearch"), HttpPost]
        public IHttpActionResult SaveSearch( string s)
        {
            BL.SearchBL.SaveSearch(s);
            return Ok(true);
        }
    }
}
