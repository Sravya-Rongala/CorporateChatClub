using Microsoft.AspNetCore.Mvc;
using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Application.DTO.Users;
using WebApi.Application.DTO.Users.ViewModels;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public AdminController() 
        { 

        }

        [HttpGet("inactiveclubs")]
        public IEnumerable<InActiveClub[]> GetInActiveClubs()
        {
            IEnumerable<InActiveClub[]> a = new List<InActiveClub[]>();
            return a;
        }

        [HttpGet("available")]
        public IEnumerable<AvailableClubs> GetAvailableClubs()
        {
            IEnumerable<AvailableClubs> a = new List<AvailableClubs>();
            return a;
        }

        [HttpGet("userdetails/{userid}")]
        public UserProfile GetUserDetails(Guid UserId)
        {
            return new UserProfile();
        }

        [HttpPost("adduser")]
        public User AddUser(User addUser)
        {
            return new User();
        }

        [HttpPut("club/activationstatus")]
        public void UpdateClubActivationStatus(Action action)
        {

        }

        [HttpPut("user/activationstatus")]
        public UserStatus  UpdateUserActivationStatus(Action action)
        {
            return new UserStatus();
        }

        [HttpDelete("club")]
        public void DeleteClub(Action action)
        {

        }

        [HttpDelete("user")]
        public void DeleteUser(Action action)
        {

        }
       
    }
}
