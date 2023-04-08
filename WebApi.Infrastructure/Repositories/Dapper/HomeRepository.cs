using Dapper;
using System.Data;
using WebApi.Domain.Data;
using WebApi.Domain.ViewModels;
using WebApi.Domain.ViewModels.Chats;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels.Users;
using WebApi.Infrastructure.Interfaces;
using WebApi.Users.ViewModels.Users;

namespace WebApi.Infrastructure.Repositories.Dapper
{
    public class HomeRepository : IHomeRepository
    {
        private DbContext _db;

        private IDbConnection connection;
        public HomeRepository(DbContext db)
        {
            this._db = db;
            this.connection = this._db.CreateConnection();
        }

        public IEnumerable<Chat> GetUserClubs(Guid UserId)
        {
            var query = "SELECT ReceiverId,ReceiverName,ProfilePicture,LastMessageUserName,LastMessage,LastAttachment,LastMessageTime,UnSeenMessageCount,IsUserFavorite from UserClubView where UserId=@userid";

            return this.connection.Query<Chat>(query, new { UserId });
        }

        public ClubDescription GetClubDescription(Guid ClubId,Guid UserId)
        {
            var query = $"SELECT Name as ClubName,ClubType,Description,ProfilePicture as ClubProfilePicture,ClubCreatedBy,ClubCreatedOn,MemberCount as ClubParticipantsCount, IsMuted from ClubDescriptionView c INNER JOIN UserClubAction u on c.Id = u.ClubId where u.UserId = '{UserId}' and c.Id = '{ClubId}'";
            return this.connection.QuerySingle<ClubDescription>(query);
        }

        public IEnumerable<ClubParticipant> GetClubParticipants(Guid ClubId)
        {
            var query = "select Id as ParticipantId ,Email as ParticipantEmail,DisplayName as ParticipantName,ProfilePicture as " +
                "ParticipantProfilePicture,IsBlocked,IsActive,Role as ParticipantRole from ClubParticipantsView where ClubId =@clubid";
            return this.connection.Query<ClubParticipant>(query, new { clubid = ClubId });
        }

        public IEnumerable<Domain.ViewModels.Clubs.ClubRequest> GetClubRequests(Guid ClubId)
        {
            var query = "select RequestedBy as RequestedUserId,DisplayName as Name,ProfilePicture,Email,RequestStatus from ClubRequestsView where ClubId=@clubid";
            return this.connection.Query<Domain.ViewModels.Clubs.ClubRequest>(query, new { clubid = ClubId });
        }

        public IEnumerable<SuggestedUser> GetSuggestedUsers(Guid UserId, Guid ClubId)
        {
            var query = "SELECT u.Id as UserId,u.DisplayName as UserName,u.JobTitle as UserJobTitle,u.ProfilePicture as UserProfilePictire " +
                "FROM Users u WHERE u.Id NOT IN ( SELECT UserId FROM ClubMember  WHERE ClubId = @clubid)AND u.Id != @userid";
            return this.connection.Query<SuggestedUser>(query, new { userId = UserId, clubid = ClubId });
        }
        public ChatInformation GetChatInformation(Guid UserId, Guid ClubId)
        {
            var query = "select ChatId,ChatName,IsFavouriteChat ,IsChatMuted from UserClubChatDetailsView where UserId= @userid and ChatId=@clubid";
            return this.connection.QuerySingle<ChatInformation>(query, new { userid = UserId, clubid = ClubId });
        }
        public IEnumerable<Domain.ViewModels.Chats.Message> GetChatMessages(Guid ClubId)
        {
            var query = "SELECT ClubId as ReceiverId,Attachment as MessageAttachment,Body as MessageBody,SenderId,CASE WHEN SenderId IS NULL THEN 1 ELSE 0 END AS MessageBodyType,SentTime AS MessageTime,DisplayName as SenderName,ProfilePicture as SenderProfilePicture FROM ClubChatHistoryView WHERE ClubId = @clubid order by SentTime";
            return this.connection.Query<Domain.ViewModels.Chats.Message>(query, new { clubid = ClubId });
        }
        public bool IsUserExist(Guid UserId)
        {
            var query = "SELECT 1 FROM Users WHERE Id = @UserId";
            return this.connection.QueryFirstOrDefault<bool>(query, new { UserId });
        }

        public string GetUserName(Guid UserId)
        {
            var query = "Select DisplayName from Users where Id=@UserId";
            return this.connection.QuerySingle<string>(query, new { UserId });
        }
        public Guid SendMessagetoClub(Domain.Entities.Chat.Message message, Guid UserId, bool IsUpdationMessage)
        {
            if (!IsUpdationMessage)
            {
                message.SenderId = UserId;
                message.SentTime = DateTime.Now;
                message.IsSeen = true;
            }
            string query;
            Guid MessageId = Guid.NewGuid();
            if (message.Body != null)
            {
                query = "insert into Message(SenderId,ClubId,Body,SentTime,IsSeen) OUTPUT Inserted.Id Values(@SenderId,@ReceiverId,@Body,@SentTime,@IsSeen)";
                MessageId = this.connection.QuerySingle<Guid>(query, message);
            }
            foreach (var attachment in message.Attachment!)
            {
                query = "insert into Message(SenderId,ClubId,Attachment,SentTime,IsSeen) OUTPUT Inserted.Id Values(@SenderId,@ReceiverId,@attachment,@SentTime,@IsSeen)";
                MessageId = this.connection.QuerySingle<Guid>(query, message);
            }
            return MessageId;
        }
        public Guid SendMessagetoUser(Domain.Entities.Chat.Message message, Guid UserId)
        {
            message.SenderId = UserId;
            message.IsSeen = true;
            message.SentTime = DateTime.Now;
            string query;
            Guid MessageId = Guid.NewGuid();
            if (message.Body != null)
            {
                query = "insert into Message(SenderId,ReceiverId,Body,SentTime,IsSeen) OUTPUT Inserted.Id Values(@SenderId,@ReceiverId,@Body,@SentTime,@IsSeen)";
                MessageId = this.connection.QuerySingle<Guid>(query, message);
            }
            foreach(var attachment in message.Attachment!)
            {
                query = "insert into Message(SenderId,ReceiverId,Attachment,SentTime,IsSeen) OUTPUT Inserted.Id Values(@SenderId,@ReceiverId,@attachment,@SentTime,@IsSeen)";
                MessageId = this.connection.QuerySingle<Guid>(query, message);
            }
            return MessageId;
        }

        public void AddUserToClub(Guid UserId, Guid ClubId, Guid AddedBy)
        {
            var query = "insert into ClubMember(ClubId,UserId,AddedBy,AddedOn,Role) Values(@clubid,@userid,@addedby,@addedon,@role)";
            this.connection.Execute(query, new { clubid = ClubId, userid = UserId, addedby = AddedBy, addedon = DateTime.Now, role = 3 });
        }

        public void AddUserClubAction(Guid UserId, Guid ClubId)
        {
            var query = "insert into UserClubAction(UserId,ClubId) values (@userid,@clubid)";
            this.connection.Execute(query, new { userid = UserId, clubid = ClubId });
        }
        public bool UpdateUserClubRequestStatus(Domain.Entities.Connection.ClubRequest clubRequestStatus, Guid UserId)
        {
            var query = "update ClubRequest set RequestStatus=@RequestStatus where ClubId=@ClubId and RequestedBy=@RequestedBy";
            bool a = this.connection.Execute(query, clubRequestStatus) > 0;
            this.AddUserToClub(clubRequestStatus.RequestedBy, clubRequestStatus.ClubId, UserId);
            return a;
        }


        public bool MakeFavouriteClubChat(ActionUpdater actionUpdater, Guid UserId)
        {
            actionUpdater.ActionTargetId = UserId;
            var query = "update UserClubAction set IsFavourite=~IsFavourite where ClubId=@actiontargetId and UserId=@actiontakenby";

            return this.connection.Execute(query, actionUpdater) > 0;
        }

        public Guid GetConnectionId(ActionUpdater actionUpdater, Guid UserId)
        {
            actionUpdater.ActionTargetId = UserId;
            var query = "select Id from UserConnection where UserId=@ActionTakenBy and ConnectedUserId=@ActionTargetId";
            return this.connection.QuerySingle<Guid>(query, actionUpdater);
        }
        public bool MakeFavouriteUserChat(ActionUpdater actionUpdater, Guid UserId)
        {
            Guid Id = this.GetConnectionId(actionUpdater, UserId);
            var query = "update UserChat set IsFavourite=~IsFavourite where UserConnectionId=@id";
            return this.connection.Execute(query, new { id = Id }) > 0;
        }

        public bool MuteClubChat(ActionUpdater actionUpdater, Guid UserId)
        {
            actionUpdater.ActionTargetId = UserId;
            var query = "update UserClubAction set IsMuted=~IsMuted where ClubId=@actiontargetid and UserId=@actiontakenby";
            return this.connection.Execute(query, actionUpdater) > 0;
        }

        public bool MuteUserChat(ActionUpdater actionUpdater, Guid UserId)
        {
            Guid Id = this.GetConnectionId(actionUpdater, UserId);
            var query = "update UserChat set IsMuted=~IsMuted where UserConnectionId=@id";
            return this.connection.Execute(query, new { id = Id }) > 0;
        }
        public bool ExitClub(Guid UserId, Guid ClubId)
        {
            var query = "update UserClubAction set IsExited=~IsExited,ExitedOn=@exitedon where ClubId=@clubid and UserId=@userid";
            return this.connection.Execute(query, new { exitedon = DateTime.Now, clubid = ClubId, userid = UserId }) > 0;
        }

        public bool RemoveAsAdmin(UserAction userAction, Guid UserId)
        {
            userAction.ActionTargetId = UserId;
            var query = "update ClubMember set Role=3 where UserId=@ActionTargetId and ClubId=@ClubId";
            return this.connection.Execute(query, userAction) > 0;
        }
        public bool BlockParticipant(UserAction userAction, Guid UserId)
        {
            userAction.ActionTargetId = UserId;
            var query = "update ClubMember set IsBlocked=~IsBlocked ,BlockedBy=@ActionTakenBy where ClubId=@ClubId and UserId=@ActionTargetId";
            return this.connection.Execute(query, userAction) > 0;
        }
    }
}