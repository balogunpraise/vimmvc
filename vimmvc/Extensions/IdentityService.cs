using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using vimmvc.Services;

namespace vimmvc.Extensions
{
	public static class IdentityService
	{
		public static IServiceCollection AddIdentityService(this IServiceCollection service, IConfiguration config)
		{
			var builder = service.AddIdentity<ApplicationUser, IdentityRole>();
			builder.AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
			builder.AddSignInManager<SignInManager<ApplicationUser>>();
			service.AddScoped<AuthServices>();
			service.AddScoped<CourseService>();
			service.AddScoped<StaffService>();
			service.AddScoped<StudentService>();
			service.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
				.AddJwtBearer(option =>
				{
					option.TokenValidationParameters = new TokenValidationParameters
					{
						ValidateIssuerSigningKey = true,
						IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Token:Key"])),
						ValidIssuer = config["Token:Issuer"],
						ValidateIssuer = true,
						ValidateAudience = false
					};
				});
			return service;
		}
	}
}
