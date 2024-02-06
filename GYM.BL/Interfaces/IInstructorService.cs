using GYM.Models.Models;

namespace GYM.BL.Interfaces
{
    public interface IInstructorService
    {
        List<Instructor> GetAll();

        Instructor? GetById(int id);

        void Add(Instructor instructor);

        void Delete(int id);
    }
}
