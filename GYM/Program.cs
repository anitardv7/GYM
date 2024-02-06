using GYM.BL.Interfaces;
using GYM.BL.Services;
using GYM.DL.Interfaces;
using GYM.DL.Repositories;
using GYM.HealthChecks;
using FluentValidation;
using FluentValidation.AspNetCore;
using GYM.HealthChecks;

namespace GYM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IInstructorRepository, InstructorRepository>();
            builder.Services.AddSingleton<IInstructorService, InstructorService>();
            builder.Services.AddSingleton<IGymsRepository, GymsRepository>();
            builder.Services.AddSingleton<IGymsService, GymsService>();
            builder.Services.AddSingleton<ICustomerService, CustomerService>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));
            builder.Services.AddHealthChecks().AddCheck<CustomHealthCheck>(nameof(CustomHealthCheck));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapHealthChecks("/healthz");

            app.MapControllers();

            app.Run();
        }
    }
}