using AutoMapper;
using CarLine.Model.Entity;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace CarLine.Service.Services.CarServices.Dto
{
    public class CarPictureUrlResolver : IValueResolver<Car, CarDetailsDto, List<PictureDto>>
    {
        private readonly IConfiguration _configuration;

        public CarPictureUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        public List<PictureDto> Resolve(Car source, CarDetailsDto destination, List<PictureDto> destMember, ResolutionContext context)
        {
            if (source.PictureUrl == null || !source.PictureUrl.Any())
                return new List<PictureDto>();

            string BaseUrl = GetNgrokUrl().Result ?? _configuration["BaseUrl"];

            return source.PictureUrl.Select(p => new PictureDto
            {
                Id = p.Id,
                PictureUrl = $"{BaseUrl}/{p.PictureUrl}",
                CarDtoId = p.CarId
            }).ToList(); 
        }

        private static async Task<string> GetNgrokUrl()
        {
            using HttpClient client = new HttpClient();

            string ngrokApiUrl = "http://localhost:4040/api/tunnels";
            try
            {
                string response = await client.GetStringAsync(ngrokApiUrl);
                JObject json = JObject.Parse(response);
                string Ngrokurl = json["tunnels"]?[0]?["public_url"]?.ToString();

                if(!string.IsNullOrEmpty(Ngrokurl)&&! Ngrokurl.Contains("localhost"))
                {
                    return Ngrokurl;
                }

            }
            catch (Exception)
            {

            }
                return null;


        }


        
    }

    




   
}
