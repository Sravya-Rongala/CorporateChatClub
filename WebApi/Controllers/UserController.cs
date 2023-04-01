using Microsoft.AspNetCore.Mvc;
using WebApi.Application.DTO.Users;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public UserController()
        {

        }

        [HttpGet("allusersinformation")]
        public IEnumerable<UserDetails> GetAllUsers()
        {
            IEnumerable<UserDetails> a = new List<UserDetails>();
            return a;
        }

        [HttpPut("userprofilepicture")]
        public UserProfilePicture UpdateProfilePicture(UserProfilePicture picture)
        {
            return new UserProfilePicture();
        }

        [HttpPut("userpersonaldetails")]
        public UserPersonalDetails UpdatePersonalDeails(UserPersonalDetails personalDetails)
        {
            return new UserPersonalDetails();
        }

        [HttpPut("usersummary")]
        public UserSummary UpdateUserSummary(UserSummary userSummary)
        {
            return new UserSummary();
        }

        [HttpPut("usercontactdetails")]
        public UpdatedUserContactDetails UpdateContactDetails(UpdatedUserContactDetails updatedcontactDetails)
        {
            return new UpdatedUserContactDetails();
        }

    }
}
