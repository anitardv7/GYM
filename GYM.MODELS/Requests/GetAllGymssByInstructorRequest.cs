using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Models.Requests
{
    public class GetAllGymssByInstructorRequest
    {
        public int InstructorId { get; set; }

        public DateTime AfterDate { get; set; }
    }
}
