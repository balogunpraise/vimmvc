using Core.Application.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
	public static class ServiceExtensions
	{
		public static IServiceCollection AddInfrastructureConfiguration(this IServiceCollection service, IConfiguration config)
		{
			var connectionString = config.GetConnectionString("DefaultConnection");
			service.AddDbContext<ApplicationDbContext>(option =>
			option.UseMySql(connectionString, serverVersion: ServerVersion.AutoDetect(connectionString)));
			service.AddTransient<TokenService>();
			service.AddScoped<ICourseRepository, CourseRepository>();
			service.AddScoped<IStudentRepository, StudentRepository>();
			return service;
		}
	}
}
