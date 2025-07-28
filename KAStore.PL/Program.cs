using KAStore.BLL.Serviece.Classes;
using KAStore.BLL.Serviece.Interfaces;
using KAStore.DAL.Data;
using KAStore.DAL.Model;
using KAStore.DAL.Reposteries.Classes;
using KAStore.DAL.Reposteries.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KAStore.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseSqlServer(builder.Configuration.GetConnectionString("DefualtConnection")));
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IBrandRepository, BrandRepository>();


            builder.Services.AddScoped <ICategoryServiece,CategoryServiece>();
            builder.Services.AddScoped<IBrandServices,BrandServiece>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
