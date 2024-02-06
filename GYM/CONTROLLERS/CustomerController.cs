using GYM.BL.Interfaces;
using GYM.Models.Requests;
using GYM.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GYM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService CustomerService)
        {
            _customerService = CustomerService;
        }

        [HttpPost("GetAllGymssByInstructor")]
        public GetAllGymssByInstructorResponse?

            GetAllGymssByInstructor([FromBody] GetAllGymssByInstructorRequest request)
        {
            return _customerService.GetAllGymssByInstructor(request);

        }
        [HttpPost("TestEndPoint")]
        public string TestEndPoint([FromBody] GetAllGymssByInstructorRequest request)
        {


            GetAllGymssByInstructorRequest request);
            {
                return "Ok";
            }
        }
    }
}



