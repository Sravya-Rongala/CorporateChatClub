using Microsoft.AspNetCore.Mvc;
using WebApi.Application.DTO.Users;
using WebApi.Domain.ViewModels.Users;
using WebApi.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {


        private readonly IUserService _userService;
       
        public UserController(IUserService UserService)
        {
            _userService = UserService;
        }

        [HttpGet("{userid:Guid}")]
        public UserInformationDTO GetUserInformation(Guid userid)
        {
            return _userService.GetUserInformation(userid);
        }

        [HttpPut("profilepicture/{userid:Guid}")]
        public bool UpdateProfilePicture(Guid userid,string Picture)
        {
            return _userService.UpdateProfilePicture(userid,Picture);
        }

        [HttpPut("personaldetails/{userid:Guid}")]
        public bool UpdatePersonalDetails(Guid userid, UserPersonalDetailsDTO personalDetails)
        {
            return _userService.UpdatePersonalDetails(userid,personalDetails);
        }

        [HttpPut("summary/{userid:Guid}")]
        public bool UpdateUserSummary(Guid userid,string userSummary)
        {
            return _userService.UpdateUserSummary(userid,userSummary);
        }

        [HttpPut("contactdetails/{userid:Guid}")]
        public bool UpdateContactDetails(Guid userid, UserContactDetailsDTO contactDetails)
        {
            return _userService.UpdateContactDetails(userid,contactDetails);
        }

    }
}
