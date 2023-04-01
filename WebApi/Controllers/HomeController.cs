﻿using Microsoft.AspNetCore.Mvc;
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
        public IEnumerable<Message> GetUserClubChatHistory(Guid ClubId, Guid UserId)
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

        [HttpPut("favouriteChat/{userid}/{chatid}")]
        public void MakeFavouriteChat(Guid UserId,Guid ChatId)
        {

        }

        [HttpPut("exitclub/{userid}/{clubid}")]
        public void ExitClub(Guid UserId, Guid ClubId)
        {

        }

        [HttpPut("mutechat/{userid}/{chatid}")]

        public void MuteChat(Guid UserId, Guid ChatId)
        {

        }

        [HttpPut("removeasadmin")]
        public void RemoveAsAdmin(UserAction userAction)
        {

        }

        [HttpPost("message/{message}")]
        public Message SendMessage(Message message)
        {
            return new Message { };
        }

        [HttpPost("userstoclub/{useridlist}")]
        public void AddUsersToClub(List<Guid> UserIdList)
        {

        }

        [HttpPost("blockuser")]
        public void BlockUser(UserAction userAction)
        {

        }

    }
}
