using GYM.DL.Interfaces;
using GYM.DL.MemoryDB;
using GYM.Models.Models;
using GYM.DL.MemoryDB;
using System.Xml.Linq;

namespace GYM.DL.Repositories
{
    public class InstructorRepository : IInstructorRepository
    {
        public List<Instructor> GetAll()
        {
            return InMemoryDB.InstructorData;
        }

        public Instructor? GetById(int id)
        {
            return InMemoryDB.InstructorData.FirstOrDefault(a => a.Id == id);
        }

        public void Add(Instructor instructor)
        {
            InMemoryDB.InstructorData.Add(instructor);
        }

        public void Delete(int id)
        {
            var Instructor = GetById(id);

            if (Instructor != null)
            {
                InMemoryDB.InstructorData.Remove(Instructor);
            }
        }
    }
}