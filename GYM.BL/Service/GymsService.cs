using GYM.BL.Interfaces;
using GYM.DL.Repositories;
using GYM.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.BL.Services
{
    public class GymsService : IGymsService

    {
        private readonly IGymsRepository _gymsRepository;
        public GymsService(IGymsRepository gymsRepository)
        {
            _gymsRepository = gymsRepository;
        }
        public List<Gyms> GetAllGymssByAuthor(int InstructorId)
        {
            return _gymsRepository.GetAllGymssByInstructor(instructorId);
        }
    }
}
