using Microsoft.AspNetCore.Mvc;
using WebApi.Application.DTO.Users;
using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Application.DTO.Users.ViewModels;
using WebApi.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly IAdminService _adminservices;
        public AdminController(IAdminService AdminServices)
        {
            _adminservices = AdminServices;
        }

       /* [HttpGet("inactiveclubs")]
        public IEnumerable<InActiveClub> GetInActiveClubs()
        {
            return _adminservices.GetInActiveClubs();
        }

        [HttpGet("available")]
        public IEnumerable<AvailableClubsDTO> GetAvailableClubs()
        {
            return _adminservices.GetAvailableClubs();
        }

        [HttpGet("userdetails/{userid}")]
        public IEnumerable<UserProfileDTO> GetAllUsers(Guid UserId)
        {
            return _adminservices.GetAllUsers(UserId);
        }
*/
        [HttpPost("adduser")]
        public Guid AddUser(UserDTO addUser)
        {
           return   _adminservices.AddNewUser(addUser);
        }

     /*   [HttpPut("club/activationstatus")]
        public void UpdateClubActivationStatus(Action action)
        {
            _adminservices.UpdateClubActivationStatus(action);
        }

        [HttpPut("user/activationstatus")]
        public UserStatus UpdateUserActivationStatus(Action action)
        {
            return _adminservices.UpdateClubActivationStatus(action);
        }

        [HttpDelete("club")]
        public void DeleteClub(Action action)
        {
            _adminservices.DeleteClub(action);
        }

        [HttpDelete("user")]
        public void DeleteUser(Action action)
        {
            _adminservices.DeleteUser(action);
        }*/
       
    }
}
