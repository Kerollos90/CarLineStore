
using AutoMapper;
using Carline.Web.Extensions;
using Carline.Web.Middleware;
using CarLine.Model.Context;
using CarLine.Model.Entity;
using CarLine.Repository.Interfices;
using CarLine.Repository.Repostories;
using CarLine.Service.HandelErros;
using CarLine.Service.Services.AppSellerServices;
using CarLine.Service.Services.AppSellerServices.Dto;
using CarLine.Service.Services.CarServices;
using CarLine.Service.Services.CarServices.Dto;
using CarLine.Service.Services.CarShowRoomServices;
using CarLine.Service.Services.CarShowRoomServices.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Writers;

namespace Carline.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //builder.WebHost.ConfigureKestrel(options => options.ListenAnyIP(7269));

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



            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<ICarShowRoomServices, CarShowRoomService>();
            builder.Services.AddScoped<ICarService, CarService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddAutoMapper(typeof(CarProfile));
            builder.Services.AddAutoMapper(typeof(UserProfile));    
            builder.Services.AddAutoMapper(typeof(ShowRoomProfile));    
            builder.Services.AddScoped<CarPictureUrlResolver>();
            builder.Services.AddScoped<OnePictureResolver>();

            builder.Services.Configure<ApiBehaviorOptions> (configure =>
            {
                    configure.InvalidModelStateResponseFactory = context =>
                    {
                        var errors = context.ModelState
                            .Where(e => e.Value.Errors.Count > 0)
                            .SelectMany(x => x.Value.Errors)
                            .Select(x => x.ErrorMessage).ToList();

                        var errorResponse = new ValidationErrorResponse
                        {
                            Errors = errors

                        };
                        return new BadRequestObjectResult(errorResponse);
                    };


            });

            builder.Services.AddIdentityApplicationServices(builder.Configuration);

            


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

           // app.UseMiddleware<ExceptionMiddleware>();



            app.UseResponseCaching();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
