using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    public class TdKWordController : ApiController
    {
        [EnableCors("*", "*", "*")]
        [RoutePrefix("api/KWord")]
        public class TbKeyWordController : ApiController
        {
            [Route("getKWordId")]
            [HttpGet]
            public IHttpActionResult GetKWordId()
            {
                return Ok("123");
            }

            [Route("getKwordNeme")]
            [HttpGet]
            public IHttpActionResult GetKwordNeme()
            {
                return Ok("456");
            }
            [Route("AddKWordName"), HttpPost]
            public IHttpActionResult AddKWordName(KWordDTO kWord)
            {
                BL.KWordBL.AddKWord(kWord);
                return Ok(true);
            }

        }
    }
}
