/*using Microsoft.AspNetCore.Mvc;
using WebApi.Application.DTO.Chats;
using WebApi.Application.DTO.Clubs;
using WebApi.Application.DTO.Users;


namespace WebApi.Controllers.HomeController
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        public HomeController() 
        {

        }

        [HttpGet("alluserclubs/{userid}")]
        public IEnumerable<Chat> GetAllUserClubs(Guid UserId)
        {
            IEnumerable<Chat> a = new List<Chat>();
            return a;
        }

        [HttpGet("userclubchat/{clubid}/{userid}")]
        public ChatHistory GetUserClubChatHistory(Guid ClubId, Guid UserId)
        {
            IEnumerable<Message> a = new List<Message>();
            return a;
        }

        [HttpGet("userclubinformation/{clubid}")]
        public ClubDetails GetUserClubInformation(Guid ClubId)
        {
            ClubDetails a= new ClubDetails();
            
            
            return new ClubDetails { };
        }

        [HttpGet("suggestedusers/{clubid}")]
        public IEnumerable<SuggestedUser> GetSuggestedUsers(Guid ClubId)
        {
            IEnumerable<SuggestedUser> a = new List<SuggestedUser>();
            return a;
        }

        [HttpPut("clubrequeststatus")]
        public void UpdateUserClubRequestStatus(ClubRequestStatus clubRequestStatus) 
        {

        }

        [HttpPut("favouriteChat")]
        public void MakeFavouriteChat(ActionUpdater action)
        {

        }

        [HttpPut("exitclub/{userid}/{clubid}")]
        public void ExitClub(Guid UserId, Guid ClubId)
        {

        }

        [HttpPut("mutechat")]

        public void MuteChat(ActionUpdater action)
        {

        }

        [HttpPut("removeasadmin")]
        public void RemoveAsAdmin(UserAction userAction)
        {

        }


        [HttpPut("blockuser")]
        public void BlockUser(UserAction userAction)
        {

        }

        [HttpPost("message")]
        public Message SendMessage(Message message)
        {
            return new Message { };
        }

        [HttpPost("userstoclub")]
        public void AddUsersToClub(List<Guid> UserIdList,Guid ClubId,Guid UserId)
        {

        }

    }
}
*/