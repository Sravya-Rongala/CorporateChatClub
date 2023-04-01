using Microsoft.AspNetCore.Mvc;
using WebApi.Application.DTO.Chats;
using WebApi.Application.DTO.Connections;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConnectionController : ControllerBase
    {
        public ConnectionController()
        {

        }

        [HttpGet("alluserconnections")]
        public IEnumerable<Chat> GetAllUserChats()
        {
            IEnumerable<Chat> a = new List<Chat>();
            return a;
        }

        [HttpGet("userchathistory/{userid}/{receiverid}")]
        public IEnumerable<Message> GetUserChatHistory(Guid UserId, Guid ReceiverId)
        {
            IEnumerable<Message> a = new List<Message>();
            return a;
        }

        [HttpGet("suggestedconnection")]
        public IEnumerable<SuggestedConnection> GetSuggestedConnections()
        {
            IEnumerable<SuggestedConnection> a = new List<SuggestedConnection>();
            return a;
        }

        [HttpGet("pendingconnection/{userid}/{requesteduserid}")]
        public PendingConnection GetPendingConnection(Guid UserId,Guid RequestedUserId) 
        {
            return new PendingConnection();
        }

        [HttpGet("unseenconnectioncount/{userid}")]
        public int GetUnseenConnectionCount(Guid UserId)
        { 
            return 0; 
        }

        [HttpPost("connectionrequest/{userid}/{requesteduserid}")]
        public void SendConnectionRequest(Guid UserId, Guid RequestedUserId)
        {
            
        }




    }
}
