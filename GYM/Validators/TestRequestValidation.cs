using GYM.Models.Requests;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace GYM.Validators
{
    public class TestRequestValidation : AbstractValidator<GetAllGymssByInstructorRequest>
    {

        public TestRequestValidation()
        {
            RuleFor(x => x.InstructorId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0).WithMessage("> 0");

            RuleFor(x => x.AfterDate)
                .NotEmpty()
                .NotNull();

        }
    }
}


