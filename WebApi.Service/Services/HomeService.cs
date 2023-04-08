using AutoMapper;
using WebApi.Application.DTO;
using WebApi.Application.DTO.Chats;
using WebApi.Application.DTO.Clubs;
using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Application.DTO.Users;
using WebApi.Domain.Entities.Chat;
using WebApi.Domain.ViewModels;
using WebApi.Infrastructure.Interfaces;
using WebApi.Interfaces;
using WebApi.Users.ViewModels.Users;

namespace WebApi.Service.Services
{
    public class HomeService : IHomeService
    {
        private IHomeRepository _homeRepository;

        private IMapper _mapper;
        public HomeService(IHomeRepository homeRepository, IMapper mapper)
        {
            _homeRepository = homeRepository;
            _mapper = mapper;
        }
        public IEnumerable<ChatDTO> GetUserClubs(Guid UserId)
        {
            return _mapper.Map<IEnumerable<ChatDTO>>(_homeRepository.GetUserClubs(UserId));

        }
        public ChatHistoryDTO GetClubChatHistory(Guid UserId, Guid ClubId)
        {
            ChatInformationDTO chatInformationDTO = _mapper.Map<ChatInformationDTO>(_homeRepository.GetChatInformation(UserId, ClubId));

            IEnumerable<MessageDTO> messages = _mapper.Map<IEnumerable<MessageDTO>>(_homeRepository.GetChatMessages(ClubId));

            ChatHistoryDTO chatHistory = new ChatHistoryDTO();
            chatHistory.ChatInformation = chatInformationDTO;
            chatHistory.Messages = messages;
            return chatHistory;
        }
        public ClubDetailsDTO GetClubDetails(Guid ClubId,Guid UserId)
        {
            ClubDescriptionDTO clubDescription = _mapper.Map<ClubDescriptionDTO>(_homeRepository.GetClubDescription(ClubId,UserId));
            IEnumerable<ClubParticipantDTO> clubParticipants = _mapper.Map<IEnumerable<ClubParticipantDTO>>(_homeRepository.GetClubParticipants(ClubId));
            IEnumerable<ClubRequestDTO> clubRequests = _mapper.Map<IEnumerable<ClubRequestDTO>>(_homeRepository.GetClubRequests(ClubId));

            ClubDetailsDTO clubdetails = new ClubDetailsDTO();
            clubdetails.ClubDescription = clubDescription;
            clubdetails.ClubParticipants = clubParticipants.ToList();
            clubdetails.ClubRequests = clubRequests.ToList();

            return clubdetails;
        }
        public IEnumerable<SuggestedUserDTO> GetSuggestedUsers(Guid UserId, Guid ClubId)
        {
            return _mapper.Map<IEnumerable<SuggestedUserDTO>>(_homeRepository.GetSuggestedUsers(UserId, ClubId));

        }

        public Guid SendMessage(PostMessageDTO Message, Guid UserId)
        {
            if (Message.IsClub)
            {
                return _homeRepository.SendMessagetoClub(_mapper.Map<Domain.Entities.Chat.Message>(Message), UserId, false);

            }
            else
            {
                return _homeRepository.SendMessagetoUser(_mapper.Map<Domain.Entities.Chat.Message>(Message), UserId);
            }

        }
        public void AddUsersToClub(List<Guid> UserIdList, Guid ClubId, Guid UserId)
        {
            foreach (var id in UserIdList)
            {
                _homeRepository.AddUserToClub(id, ClubId, UserId);

                _homeRepository.AddUserClubAction(id, ClubId);
                Message message = new Message();
                message.ReceiverId = ClubId;
                message.SenderId = Guid.Empty;
                message.Body = _homeRepository.GetUserName(UserId) + "Added";
                message.SentTime = DateTime.Now;
                message.IsSeen = true;
                _homeRepository.SendMessagetoClub(message, UserId, true);
            }

        }

        public bool UpdateUserClubRequestStatus(ClubRequestStatusDTO clubRequestStatus, Guid UserId)
        {
            if (_homeRepository.IsUserExist(UserId))
            {

                return _homeRepository.UpdateUserClubRequestStatus(_mapper.Map<Domain.Entities.Connection.ClubRequest>(clubRequestStatus), UserId);
            }
            else
            {
                return false;
            }

        }
        public bool MakeFavouriteChat(ActionUpdaterDTO actionUpdaterDTO, Guid UserId)
        {
            if (_homeRepository.IsUserExist(UserId))
            {
                if (actionUpdaterDTO.IsClub == true)
                {
                    return _homeRepository.MakeFavouriteClubChat(_mapper.Map<ActionUpdater>(actionUpdaterDTO), UserId);
                }
                else
                {
                    return _homeRepository.MakeFavouriteUserChat(_mapper.Map<ActionUpdater>(actionUpdaterDTO), UserId);
                }
            }
            else
            {
                return false;
            }


        }
        public bool MuteChat(ActionUpdaterDTO actionUpdaterDTO, Guid UserId)
        {
            if (_homeRepository.IsUserExist(UserId))
            {
                if (actionUpdaterDTO.IsClub == true)
                    return _homeRepository.MuteClubChat(_mapper.Map<ActionUpdater>(actionUpdaterDTO), UserId);
                else
                {
                    return _homeRepository.MuteUserChat(_mapper.Map<ActionUpdater>(actionUpdaterDTO), UserId);
                }

            }
            else
            {
                return false;
            }

        }
        public bool ExitClub(Guid UserId, Guid ClubId)
        {
            bool status = false;
            if (_homeRepository.IsUserExist(UserId))
            {
                if (_homeRepository.ExitClub(UserId, ClubId))
                {
                    Message message = new Message();
                    message.ReceiverId = ClubId;
                    message.SenderId = Guid.Empty;
                    message.Body = _homeRepository.GetUserName(UserId) + "Exited";
                    message.SentTime = DateTime.Now;
                    message.IsSeen = true;
                    if (_homeRepository.SendMessagetoClub(message, UserId, true) != Guid.Empty)
                    {
                        status = true;
                    }
                    else
                    {
                        _homeRepository.SendMessagetoClub(message, UserId, true);
                    }
                }
            }
            return status;
        }

        public bool RemoveAsAdmin(UserActionDTO userAction, Guid UserId)
        {
            bool status = false;
            if (_homeRepository.IsUserExist(UserId))
            {

                if (_homeRepository.RemoveAsAdmin(_mapper.Map<UserAction>(userAction), UserId))
                {
                    Message message = new Message();
                    message.ReceiverId = userAction.ClubId; message.SenderId = Guid.Empty;
                    message.SentTime = DateTime.Now;
                    message.IsSeen = true;
                    message.Body = _homeRepository.GetUserName(userAction.ActionTargetId) + "removed as Admin";
                    if (_homeRepository.SendMessagetoClub(message, UserId, true) != Guid.Empty)
                    {
                        status = true;
                    }
                    else
                    {
                        _homeRepository.SendMessagetoClub(message, UserId, true);
                    }
                }

            }
            return status;

        }
        public bool BlockParticipant(UserActionDTO userAction, Guid UserId)
        {
            bool status = false;
            if (_homeRepository.IsUserExist(UserId))
            {
                if (_homeRepository.BlockParticipant(_mapper.Map<UserAction>(userAction), UserId))
                {
                    Message message = new Message();
                    message.ReceiverId = userAction.ClubId;
                    message.SenderId = Guid.Empty;
                    message.IsSeen = true;
                    message.SentTime = DateTime.Now;
                    message.Body = _homeRepository.GetUserName(userAction.ActionTargetId) + "Blocked";
                    if (_homeRepository.SendMessagetoClub(message, UserId, true) != Guid.Empty)
                    {
                        status = true;
                    }
                    else
                    {
                        _homeRepository.SendMessagetoClub(message, UserId, true);
                    }
                }

            }
            return status;

        }
    }
}