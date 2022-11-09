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
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/KeyWord")]
    public class TbKeyWordController : ApiController
    {
        public IEnumerable<object> SmoothSurfing { get; private set; }

        [Route("getKeyWordId")]
        [HttpGet]
        public IHttpActionResult GetKeyWordId()
        {
            return Ok("123");
        }

        [Route("getSenId")]
        [HttpGet]
        public IHttpActionResult GetSenId()
        {
            return Ok("456");
        }
        [Route("AddKeyWord"), HttpPost]
        public IHttpActionResult AddKeyWord(KeyWordDTO keyWord)
        {
            BL.KeyWordBL.AddKeyWord(keyWord);
            return Ok(true);
        }
        //userVoiceRecorder(); to ask the teacher
        [Route("UserSearch")]
        [HttpGet]
        public IHttpActionResult  UserSearch(string searchText)
        {
            return Ok(BL.KeyWordBL.Search(searchText));
        }
        //UsergetKeyWord();
        [Route("UsergetKeyWord")]
        [HttpGet]
        public IHttpActionResult UsergetKeyWord()
        {
            return Ok("456");
        }
        
       
        //UserGetMacro (); ask the teacher
        // UsertextRecorder(); to ask the teacher


    }
}
