using GYM.BL.Interfaces;
using GYM.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace GYM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstructorController : ControllerBase
    {


        private readonly IInstructorService _instructorService;

        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Instructor>GetAll()
        {
            return _instructorService.GetAll();
        }

        [HttpGet("GetById")]

        public Instructor? GetById(int id)
        {
            return _instructorService.GetById(id);
        }

        [HttpPost("Add")]

        public void Add([FromBody] Instructor instructor)
        {
            _instructorService.Add(instructor);
        }

        [HttpDelete("Delete")]

        public void Delete(int id)
        {
            _instructorService.Delete(id);
        }
    }
}
