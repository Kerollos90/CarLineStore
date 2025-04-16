using AutoMapper;
using AutoMapper.Execution;
using AutoMapper.Internal;
using CarLine.Model.Entity;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace CarLine.Service.Services.CarServices.Dto
{
    public class OnePictureResolver : IValueResolver<Car, CarDto, List<PictureDto>>
    {
        private static  IConfiguration _configuration;

        private static string _baseUrl;
        private static string _cachedNgrokUrl = null;
        private static bool _NgrokChecked = false;






        public OnePictureResolver(IConfiguration configuration )
        {
            _configuration = configuration;
            
        }

        public List<PictureDto> Resolve(Car source, CarDto destination, List<PictureDto> tMember, ResolutionContext context)
        {
            if (source.PictureUrl == null || !source.PictureUrl.Any())
                return new List<PictureDto>();

            string BaseUrl = GetNgrokUrl().Result ?? _configuration["BaseUrl"];
            var picture = new List<PictureDto>();

            return picture = source.PictureUrl.Select(p => new PictureDto
            {
                Id = p.Id,
                PictureUrl = $"{BaseUrl}/{p.PictureUrl}",
                CarDtoId = p.CarId
            }).ToList();

        }

        internal static async Task<string> GetNgrokUrl()
        {
            if (_NgrokChecked)
                return _cachedNgrokUrl;



              

            using HttpClient httpClient = new HttpClient();

            string ngrokApiUrl = "http://localhost:4040/api/tunnels";
            try
            {



                string response = await httpClient.GetStringAsync(ngrokApiUrl)?? _configuration["BaseUrl"];
                if (!string.IsNullOrEmpty(response) && response.Contains("public_url"))
                {
                    JObject json = JObject.Parse(response);
                    string Ngrokurl = json["tunnels"]?[0]?["public_url"]?.ToString();

                    if (!string.IsNullOrEmpty(Ngrokurl) && !Ngrokurl.Contains("localhost"))
                    {
                        _cachedNgrokUrl = Ngrokurl;
                        _NgrokChecked = true;

                        return Ngrokurl;
                    }

                }

             
              
                _NgrokChecked = true;

                return _cachedNgrokUrl ?? _configuration["BaseUrl"];

            }
            catch (Exception)
            {
            }
            _NgrokChecked = true;

            return _cachedNgrokUrl ?? _configuration["BaseUrl"];
        }
    }
}