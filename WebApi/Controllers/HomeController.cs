using Microsoft.AspNetCore.Mvc;
using WebApi.Application.DTO.Chats;
using WebApi.Application.DTO.Clubs;
using WebApi.Application.DTO;
using WebApi.Application.DTO.Users;
using WebApi.Interfaces;

namespace WebApi.Controllers.HomeController
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet("{userid:Guid}/userclubs")]
        public IEnumerable<ChatDTO> GetUserClubs(Guid userid)
        {
            return _homeService.GetUserClubs(userid);

        }

        [HttpGet("clubchat/{userid:Guid}")]
        public ChatHistoryDTO GetClubChatHistory(Guid userid, Guid ClubId)
        {
            return _homeService.GetClubChatHistory(userid, ClubId);

        }

        [HttpGet("clubinformation/{clubid:Guid}/{userid:Guid}")]
        public ClubDetailsDTO GetClubDetails(Guid clubid,Guid userid)
        {

            return _homeService.GetClubDetails(clubid,userid);

        }

        [HttpGet("suggestedusers/{userid:Guid}")]
        public IEnumerable<SuggestedUserDTO> GetSuggestedUsers(Guid userid, Guid ClubId)
        {
            return _homeService.GetSuggestedUsers(userid, ClubId);

        }
        [HttpPost("message/{userid:Guid}")]
        public Guid SendMessage(PostMessageDTO message, Guid userid)
        {
            return _homeService.SendMessage(message, userid);
        }

        [HttpPost("userstoclub/{userid:Guid}")]
        public void AddUsersToClub(List<Guid> UserIdList, Guid ClubId, Guid userid)
        {
            _homeService.AddUsersToClub(UserIdList, ClubId, userid);
        }

        [HttpPut("clubrequeststatus/{userid:Guid}")]
        public bool UpdateUserClubRequestStatus(ClubRequestStatusDTO clubRequestStatus, Guid userid)
        {
            return _homeService.UpdateUserClubRequestStatus(clubRequestStatus, userid);
        }

        [HttpPut("favouriteChat/{userid:Guid}")]
        public bool MakeFavouriteChat(ActionUpdaterDTO action, Guid userid)
        {
            return _homeService.MakeFavouriteChat(action, userid);
        }

        [HttpPut("mutechat/{userid:Guid}")]

        public bool MuteChat(ActionUpdaterDTO action, Guid userid)
        {
            return _homeService.MuteChat(action, userid);
        }

        [HttpPut("exitclub/{userid:Guid}")]
        public bool ExitClub(Guid userid, Guid clubid)
        {
            return _homeService.ExitClub(userid, clubid);
        }

        [HttpPut("removeasadmin/{userid:Guid}")]
        public bool RemoveAsAdmin(UserActionDTO userAction, Guid userid)
        {
            return _homeService.RemoveAsAdmin(userAction, userid);
        }


        [HttpPut("blockuser/{userid:Guid}")]
        public bool BlockParticipant(UserActionDTO userAction, Guid userid)
        {
            return _homeService.BlockParticipant(userAction, userid);
        }



    }
}