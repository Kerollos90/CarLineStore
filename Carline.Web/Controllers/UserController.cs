using CarLine.Model.Entity;
using CarLine.Service.Services.AppSellerServices;
using CarLine.Service.Services.AppSellerServices.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Carline.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly UserManager<AppSeller> _userManager;

        public UserController(IUserService userService , UserManager<AppSeller> userManager)
        {
            _userService = userService;
            _userManager = userManager;
        }


        [HttpPost]
        public async Task<ActionResult<AppSellerDto>> LogIn(LoginDto login)
        {
            var user = await _userService.Login(login);
            if (user == null)
                return BadRequest(new Exception("Email Does Not Exist"));

            return Ok(user);
            


        }


        [HttpPost]
        public async Task<ActionResult<AppSellerDto>> Register(RegisterDto login)
        {
            var user = await _userService.Register(login);
            if (user == null)
                return BadRequest(new Exception("Email Already Exist"));

            return Ok(user);


        }

        [HttpGet]
        

        public async Task<ActionResult<AppSellerDto>> GetUserCar()
        {
            var userId = HttpContext.Session.GetString("UserId");

            if (userId == null)
                return BadRequest(new Exception("Email Does Not Exist"));


            var user = await _userService.GetUserCar(userId);


            return Ok(user);


        }

    }
}
