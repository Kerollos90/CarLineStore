using AutoMapper;
using CarLine.Model.Entity;
using CarLine.Repository.Interfices;
using CarLine.Repository.Specification.CarSpecifications;
using CarLine.Service.Services.AppSellerServices.Dto;
using CarLine.Service.Services.CarServices.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace CarLine.Service.Services.AppSellerServices
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppSeller> _userManager;
        private readonly SignInManager<AppSeller> _signIn;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(UserManager<AppSeller> userManager , 
            SignInManager<AppSeller> signIn  ,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _userManager = userManager;
            _signIn = signIn;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<AppSellerDto> GetUserCar(string Id)
        {
            var user = await _userManager.FindByEmailAsync(Id);
            if (user == null)
                throw new Exception("Not Found Email");

            var carSpecification = new CarSpecification(user.Id);

            var carResult = await _unitOfWork.Repository<Car, int>().GetAllWithSpcificationAsync(carSpecification);

            var car = _mapper.Map<List<CarDetailsDto>>(carResult);


            return new AppSellerDto
            {
                Id = user.Id,
                DisplayName = user.DisplayName,
                Email = user.Email,
                Car = car


            };
        }

        public async Task<AppSellerDto> Login(LoginDto input)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(input.Email);
                if (user == null)
                    throw new Exception("Not Found Email");

                var result = await _signIn.CheckPasswordSignInAsync(user, input.Password , false);

                if (!result.Succeeded)
                    throw new Exception("login Faild");

               

              


                return new AppSellerDto
                {
                    Id = user.Id,
                    DisplayName = user.DisplayName,
                    Email = user.Email,
                    


                };





            }
            catch (Exception ex)
            {

                throw new Exception("Not Valid");
            }
        }

        public async Task<AppSellerDto> Register(RegisterDto input)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(input.Email);

                if (user != null)
                    throw new Exception(" Email Already Exist");

                var appUser = new AppSeller
                {
                    DisplayName = input.DisplayName,
                    Email = input.Email,
                    UserName = input.DisplayName

                };

                var result = await _userManager.CreateAsync(appUser, input.Password);

                if (!result.Succeeded)
                    throw new Exception(result.Errors.Select(x => x.Description).FirstOrDefault());

                return new AppSellerDto
                {
                    
                    DisplayName = appUser.DisplayName,
                    Email = appUser.Email,
                    


                };


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
    }
}
