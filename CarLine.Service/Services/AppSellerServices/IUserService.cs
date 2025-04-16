using CarLine.Service.Services.AppSellerServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.AppSellerServices
{
    public interface IUserService
    {
        Task<AppSellerDto> Login(LoginDto input);
        Task<AppSellerDto> Register(RegisterDto input);

        Task<AppSellerDto> GetUserCar(string Id);

    }
}
