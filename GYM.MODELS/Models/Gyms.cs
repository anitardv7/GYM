using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Models.Models
{
    public class Gyms
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int InstructorID { get; set; }

        public DateTime oReleaseDate { get; set; }
    }
}
