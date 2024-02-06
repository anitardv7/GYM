using GYM.BL.Services;
using GYM.DL.Interfaces;
using GYM.DL.Repositories;
using GYM.Models.Models;
using GYM.Models.Requests;

using Moq;

namespace GYM.Tests
{
    public class CustomerServiceTests
    {
        public static List<Gyms> GymsData = new List<Gyms>()
        {
            new Gyms()
            {
                Id = 1,
                InstructorID = 1,
                ReleaseDate = new DateTime(2005, 02, 12),
                Title = "Gym 1"
            },
            new Gyms()
            {
                Id = 2,
                InstructorID = 1,
                ReleaseDate = new DateTime(2007, 02, 12),
                Title = "Gym 2"
            }
        };

        public static List<Instructor> InstructorData = new List<Instructor>()
            {
                new Instructor()
                {
                    Id = 1,
                    Name = "Instructor 1",
                    BirthDay = DateTime.Now
                },
                new Instructor()
                {
                    Id = 2,
                    Name = "Instructor 2",
                    BirthDay = DateTime.Now
                },
                new Instructor()
                {
                    Id = 3,
                    Name = "Instructor 3",
                    BirthDay = DateTime.Now
                }
            };

        [Fact]
        public void GetAllGymssCount_OK()
        {
            //setup
            var input = 10;
            var instructorId = 1;
            var expectedCount = 12;

            var mockedGymsRepository = new Mock<IGymsRepository>();
            var mockedInstructorRepository = new Mock<IInstructorRepository>();

            mockedGymsRepository.Setup(x => x.GetAllGymssByInstructor(instructorId))
                .Returns(GymsData.Where(g => g.InstructorID == instructorId).ToList());

            //inject
            var gymsService = new GymsService(mockedGymsRepository.Object);
            var instructorService = new InstructorService(mockedInstructorRepository.Object);
            var customerService = new CustomerService(gymsService, instructorService);

            //act
            var result = customerService.GetAllGymssCount(input, instructorId);

            //Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void GetAllGymssCount_WrongInstructorId()
        {
            //setup
            var input = 10;
            var instructorId = 111;
            var expectedCount = 10;

            var mockedGymsRepository = new Mock<IGymsRepository>();
            var mockedInstructorRepository = new Mock<IInstructorRepository>();

            mockedGymsRepository.Setup(x => x.GetAllGymssByInstructor(instructorId))
                .Returns(GymsData.Where(g => g.InstructorID == instructorId).ToList());

            //inject
            var gymsService = new GymsService(mockedGymsRepository.Object);
            var instructorService = new InstructorService(mockedInstructorRepository.Object);
            var customerService = new CustomerService(gymsService, instructorService);

            //act
            var result = customerService.GetAllGymssCount(input, instructorId);

            //Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void GetAllGymssCount_NegativeInput()
        {
            //setup
            var input = -10;
            var instructorId = 111;
            var expectedCount = 0;

            var mockedGymsRepository = new Mock<IGymsRepository>();
            var mockedInstructorRepository = new Mock<IInstructorRepository>();

            mockedGymsRepository.Setup(x => x.GetAllGymssByInstructor(instructorId))
                .Returns(GymsData.Where(g => g.InstructorID == instructorId).ToList());

            //inject
            var gymsService = new GymsService(mockedGymsRepository.Object);
            var instructorService = new InstructorService(mockedInstructorRepository.Object);
            var customerService = new CustomerService(gymsService, instructorService);

            //act
            var result = customerService.GetAllGymssCount(input, instructorId);

            //Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void GetAllGymssByInstructorAfterDate_OK()
        {
            //setup
            var request = new GetAllGymsByInstructorRequest
            {
                InstructorId = 1,
                AfterDate = new DateTime(2000, 1, 1)
            };
            var expectedCount = 2;

            var mockedGymsRepository = new Mock<IGymsRepository>();
            var mockedInstructorRepository = new Mock<IInstructorRepository>();

            mockedGymsRepository.Setup(x => x.GetAllGymssByInstructor(request.InstructorId))
                .Returns(GymsData.Where(g => g.InstructorID == request.InstructorId).ToList());

            mockedInstructorRepository.Setup(x => x.GetById(request.InstructorId))
                .Returns(InstructorData.FirstOrDefault(i => i.Id == request.InstructorId));

            //inject
            var gymsService = new GymsService(mockedGymsRepository.Object);
            var instructorService = new InstructorService(mockedInstructorRepository.Object);
            var customerService = new CustomerService(gymsService, instructorService);

            //Act
            var result = customerService.GetAllGymssByInstructorAfterDate(request);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Gyms.Count);
            Assert.Equal(request.InstructorId, result.Instructor.Id);
        }
    }
}