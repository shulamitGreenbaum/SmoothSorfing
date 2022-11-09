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
    [EnableCors("*","*","*")]//any localhost can connect to C#
    [RoutePrefix("api/volunteer")]//the url in google
    public class VolunteerController : ApiController

    {
        [Route("getVolunteer")]
        [HttpGet]
        public IHttpActionResult GetVolunteer()
        {
            return Ok("adina sara salzer");
        }

       
        [Route("AddVoLunteer"),HttpPost]//add the volunteer to the DB
        public IHttpActionResult AddVoLunteer(VolunteerDTO volunteer)
        {
             BL.VolunteerBL.AddVolunteer(volunteer);
            return Ok(true);
        }
        
    }
}
