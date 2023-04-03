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

        [HttpGet("inactiveclubs")]
        public IEnumerable<InActiveClubDTO> GetInActiveClubs()
        {
            return _adminservices.GetInActiveClubs();
        }

        [HttpGet("available")]
        public IEnumerable<AvailableClubsDTO> GetAvailableClubs()
        {
            return _adminservices.GetAvailableClubs();
        }

        [HttpGet("allusers")]
        public IEnumerable<UserProfileDTO> GetAllUsers()
        {
            return _adminservices.GetAllUsers();
        }

        [HttpPost("adduser")]
        public Guid AddUser(UserDTO addUser)
        {
            return _adminservices.AddNewUser(addUser);
        }

       /* [HttpPut("club/activationstatus")]
        public void UpdateClubActivationStatus(ActionUpdater action)
        {
            _adminservices.UpdateClubActivationStatus(action);
        }

        [HttpPut("user/activationstatus")]
        public UserStatusDTO UpdateUserActivationStatus(ActionUpdater action)
        {
            return _adminservices.UpdateClubActivationStatus(action);
        }

        [HttpDelete]
        public void Delete(ActionUpdater action)
        {
            _adminservices.Delete(action);
        }*/

    }
}
