using GYM.DL.MemoryDB;
using GYM.Models.Models;
using GYM.DL.MemoryDB;
using GYM.DL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.DL.Repositories
{
    public class GymsRepository : IGymsRepository
    {
        public List<Gyms> GetAllGymssByAuthor(int InstructorId)
        {
            var result = InMemoryDB.GymsData.Where(b => b.InstructorID == InstructorId).ToList();
            return result;
        }
    }
}
