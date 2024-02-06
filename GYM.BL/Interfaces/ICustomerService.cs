using GYM.Models.Requests;
using GYM.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.BL.Interfaces
{
    public interface ICustomerService
    {
        GetAllGymssByInstructorResponse?
            GetAllGymssByInstructor(GetAllGymssByInstructorRequest request);
    }
}
