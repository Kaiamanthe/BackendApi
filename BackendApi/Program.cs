using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using BackendApi.Data;
using Microsoft.AspNetCore.Identity;
using BackendApi.Areas.Identity.Data;



namespace BackendApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add DB Context
            builder.Services.AddDbContext<BackendApiContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("BackendApiContext") ?? throw new InvalidOperationException("Connection string 'BackendApiContext' not found.")));

            builder.Services.AddDefaultIdentity<BackendApiUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<BackendApiContext>();


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
