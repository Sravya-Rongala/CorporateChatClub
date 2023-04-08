/*using Dapper;
using System.Data;
using WebApi.Application.DTO.Chats;
using WebApi.Domain.Data;
using WebApi.Domain.ViewModels.Chats;
using WebApi.Domain.ViewModels.Connections;
using WebApi.Infrastructure.Interfaces;

namespace WebApi.Infrastructure.Repositories.Dapper
{
    public class ConnectionRepository : IConnectionRepository
    {
        private DbContext _db;
        private IDbConnection connection;
        public ConnectionRepository(DbContext db)
        {
            this._db = db;
            this.connection = this._db.CreateConnection();
        }
        public IEnumerable<Chat> GetAllUserChats(Guid UserID)
        {
            var query = "Select * from AllUserConnectionChatView where UserId = @UserId";
            return this.connection.Query<Chat>(query);

        }
       
        public IEnumerable<SuggestedConnection> GetSuggestedConnections(Guid UserId)
        {
            var query = $"Exec SuggestedConnections @UserId = '{UserId}'";
            return this.connection.Query<SuggestedConnection>(query);
        }
        public PendingConnection GetPendingConnection(Guid UserId, Guid RequestedUserId)
        {
            var 
        }
        public int GetUnseenConnectionCount(Guid UserId)
        {
            return 0;
        }
        public void SendConnectionRequest(Guid UserId, Guid RequestedUserId)
        {

        }
    }
}
*/