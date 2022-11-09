using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class SearchController : ApiController
    {
        [ActionName("saveChanges"), HttpPost]
        public IHttpActionResult SaveSearch( string s)
        {
            BL.SearchBL.SaveSearch();
            return Ok(true);
        }
    }
}
