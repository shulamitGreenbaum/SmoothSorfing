using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using DAL;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]//any localhost can connect to C#
    [RoutePrefix("api/Search")]//the url in google
    public class SearchController : ApiController
    {
        [ActionName("SaveSearch"), HttpPost]
        public IHttpActionResult SaveSearch( string s, int id)//recieves sentence search from angular
        {
            tbKWord newkeyword = new tbKWord(id, s); //creates new key wrod
            BL.SearchBL.SaveSearch(newkeyword); //saves the search in BL
            return Ok(true);
        }
        
    }
}
