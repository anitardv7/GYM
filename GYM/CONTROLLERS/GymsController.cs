using GYM.BL.Interfaces;
using GYM.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace GYM.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class GymsController : ControllerBase
    {

        private readonly IGymsService _gymsService;

        public GymsController(IGymsService gymsService)
        {
            _gymsService = gymsService;
        }

        [HttpGet("GetAllGymssByAuthor")]
        public IEnumerable<Gyms> GetAllGymssByAuthor(int instructorId)
        {
            return _gymsService.GetAllGymssByInstructor(instructorId);
        }
    }
}
