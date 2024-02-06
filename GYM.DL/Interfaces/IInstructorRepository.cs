using GYM.Models.Models;

namespace GYM.DL.Interfaces
{
    public interface InstructorRepository
    {
        List<Instructor> GetAll();

        Instructor? GetById(int id);

        void Add(Instructor instructor);

        void Delete(int id);
    }
}
