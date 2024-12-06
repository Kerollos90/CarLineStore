
using CarLine.Model.Context;
using CarLine.Repository.Interfices;
using CarLine.Repository.Repostories;
using CarLine.Service.Services.CarServices;
using CarLine.Service.Services.CarServices.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Writers;

namespace Carline.Web
{
    public class Program
    {
        public static   void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<StoreDbContext>(o =>
            {
               o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

               
            });

            builder.Services.AddControllers().AddJsonOptions(opt =>
            {
                opt.JsonSerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());
            });

           

            builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
            builder.Services.AddScoped<ICarService, CarService>();
            builder.Services.AddAutoMapper(typeof(CarProfile));
            


            var app = builder.Build();


            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider;

                var getdatabase = context.GetRequiredService<StoreDbContext>();

                 getdatabase.Database.MigrateAsync();
            }

            

            

            

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            
            

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
