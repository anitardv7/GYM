using GYM.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Models.Responses
{
    public class GetAllGymssByInstructorResponse
    {

        public Instructor? Instructor { get; set; }
        public List<Gyms>? Books { get; set; }
    }
}
