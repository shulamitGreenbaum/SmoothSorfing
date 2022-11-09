using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTORS
{
    public static class VolunteerConvertor
    {
        public static volunteer ConvertVolunteerToDAL(VolunteerDTO volunteer)
        {
            return new volunteer
            {
                id = volunteer.id,
                name = volunteer.name,
                password = volunteer.password,
                emailAddress = volunteer.emailAddress
               };
    }
    } 
}
