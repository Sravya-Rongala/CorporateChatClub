/*using AutoMapper;
using System.Collections.Generic;
using System.Data;
using WebApi.Application.DTO.Chats;
using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Application.DTO.Connections;
using WebApi.Domain.Data;
using WebApi.Domain.Entities.Chat;
using WebApi.Domain.ViewModels.Users;
using WebApi.Infrastructure.Interfaces;
using WebApi.Interfaces;

namespace WebApi.Service.Services
{
    public class ConnectionService : IConnectionService
    {
        private IConnectionRepository _connectionRepository;

        private IMapper _mapper;
        public ConnectionService(IConnectionRepository ConnectionRepository, IMapper mapper)
        {
            _connectionRepository = ConnectionRepository;
            _mapper = mapper;
        }
        public IEnumerable<ChatDTO> GetAllUserChats()
        { 
            return _mapper.Map<IEnumerable<ChatDTO>>(_connectionRepository.GetAllUserChats());

        }
        public ChatHistoryDTO GetUserChatHistory(Guid UserId, Guid ReceiverId)
        {
            return _mapper.Map<ChatHistoryDTO>(_connectionRepository.GetUserChatHistory(UserId, ReceiverId));
        }
        public IEnumerable<SuggestedConnectionDTO> GetSuggestedConnections(Guid UserId)
        {
            return _mapper.Map<IEnumerable<SuggestedConnectionDTO>>(_connectionRepository.GetSuggestedConnections(UserId));
        }
        public PendingConnectionDTO GetPendingConnection(Guid UserId, Guid RequestedUserId)
        {
            return _mapper.Map<PendingConnectionDTO>(_connectionRepository.GetPendingConnection(UserId, RequestedUserId));
        }
        //  public int GetUnseenConnectionCount(Guid UserId);
        public void SendConnectionRequest(Guid UserId, Guid RequestedUserId)
        {
            _connectionRepository.SendConnectionRequest(UserId, RequestedUserId);
        }
    }
}
*/