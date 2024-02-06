using GYM.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.DL.Repositories
{
    public interface IBookRepository
    {
        List<Gyms> GetAllGymssByInstructor(int instructorId);

        //  Gyms? GetByTitle(string title);
    }
}
