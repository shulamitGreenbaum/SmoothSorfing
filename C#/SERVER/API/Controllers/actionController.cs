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
    [RoutePrefix("api/Action")]
    public class ActionController : ApiController
    {
        [Route("getMacro")]
        [HttpGet]
        public IHttpActionResult GetMacro( int id)
        {
            var v = BL.ActionBL.GetMacro(id);
            return Ok(v);
        }
        [Route("getAllMacros")]
        [HttpGet]
        public IHttpActionResult GetAllMacro(string s)
        {
            var v = BL.KWordBL.Search(s);
            return Ok(v);
        }
        [Route("getIdFoMacro")]
        [HttpPost] //to do changes in the DB
        public IHttpActionResult getIdFoMacro(int id)
        {
          BL.ActionBL.AddCountFidback(id);
            return Ok(true);
        }

    }
}
