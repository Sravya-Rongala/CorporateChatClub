using Microsoft.AspNetCore.Mvc;
using WebApi.Application.DTO.Users;
using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Application.DTO.Users.ViewModels;
using WebApi.Interfaces;
using WebApi.Application.DTO;

namespace WebApi.Controllers
{
    [Route("api/admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly IAdminService _adminservices;
        public AdminController(IAdminService AdminServices)
        {
            _adminservices = AdminServices;
        }

        [HttpGet("inactive")]
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

        [HttpPost("user")]
        public Guid AddUser(UserDTO addUser)
        {
            return _adminservices.AddNewUser(addUser);
        }

        [HttpPut("activationstatus")]
        public void UpdateClubActivationStatus(ActionUpdaterDTO action)
        {
            _adminservices.UpdateActivationStatus(action);
        }

        [HttpDelete]
        public void Delete(ActionUpdaterDTO action)
        {
            _adminservices.Delete(action);
        }

    }
}
