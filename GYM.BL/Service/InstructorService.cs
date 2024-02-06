using GYM.Interfaces;
using GYM.DL.Interfaces;
using GYM.Models.Models;

namespace GYM.BL.Services
{
    public class InstructorService : IInstructorService
    {
        private readonly IInstructorRepository _InstructorRepository;

        public InstructorService(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }
        public List<Instructor> GetAll()
        {
            return _instructorRepository.GetAll();
        }

        public Instructor? GetById(int id)
        {
            if (id <= 0) return null;

            return _instructorRepository.GetById(id);
        }

        public void Add(Instructor instructor)
        {
            _instructorRepository.Add(instructor);
        }

        public void Delete(int id)
        {
            _instructorRepository.Delete(id);
        }
    }
}
