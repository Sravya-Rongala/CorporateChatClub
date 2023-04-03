/*using Microsoft.AspNetCore.Mvc;
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
        public IEnumerable<ChatDTO> GetAllUserChats()
        {
            IEnumerable<ChatDTO> a = new List<ChatDTO>();
            return a;
        }

        [HttpGet("userchathistory/{userid}/{receiverid}")]
        public ChatHistoryDTO GetUserChatHistory(Guid UserId, Guid ReceiverId)
        {
            
            return  new ChatHistoryDTO();
        }

        [HttpGet("suggestedconnection")]
        public IEnumerable<SuggestedConnectionDTO> GetSuggestedConnections()
        {
            IEnumerable<SuggestedConnectionDTO> a = new List<SuggestedConnectionDTO>();
            return a;
        }

        [HttpGet("pendingconnection/{userid}/{requesteduserid}")]
        public PendingConnectionDTO GetPendingConnection(Guid UserId, Guid RequestedUserId)
        {
            return new PendingConnectionDTO();
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
*/