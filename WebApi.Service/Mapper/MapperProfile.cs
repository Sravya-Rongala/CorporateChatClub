using AutoMapper;
using WebApi.Application.DTO;
using WebApi.Application.DTO.Chats;
using WebApi.Application.DTO.Clubs;
using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Application.DTO.Users;
using WebApi.Application.DTO.Users.ViewModels;
using WebApi.Domain.ViewModels;
using WebApi.Domain.ViewModels.Chats;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels.Users;
using WebApi.Users.ViewModels.Users;

namespace WebApi.Service.MapperProfile
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<UserStatusDTO, UserStatus>().ReverseMap();
            CreateMap<ActionUpdaterDTO, ActionUpdater>().ReverseMap();
            CreateMap<InActiveClubDTO, InActiveClub>().ReverseMap();
            CreateMap<AvailableClubsDTO, AvailableClubs>().ReverseMap();
            CreateMap<UserProfileDTO, UserProfile>().ReverseMap();
            CreateMap<UserInformationDTO, UserInformation>().ReverseMap();
            CreateMap<UserPersonalDetailsDTO, UserPersonalDetails>().ReverseMap();
            CreateMap<UserContactDetailsDTO,UserContactDetails>().ReverseMap();
            CreateMap<ClubProfileDTO, ClubProfile>().ReverseMap();
            CreateMap<ClubDTO, Club>().ReverseMap();
            CreateMap<ClubInformationDTO, ClubInformation>().ReverseMap();
            CreateMap<SuggestedUserDTO, SuggestedUser>().ReverseMap();
            CreateMap<PostMessageDTO, Domain.Entities.Chat.Message>().ForMember(dest => dest.Body, opt => opt.MapFrom(src => src.MessageBody))
                .ForMember(dest => dest.ReceiverId, opt => opt.MapFrom(src => src.ReceiverId))
                .ForMember(dest => dest.Attachment, opt => opt.MapFrom(src => src.MessageAttachement));

            CreateMap<ClubRequestStatusDTO, Domain.Entities.Connection.ClubRequest>();
            CreateMap<UserActionDTO, UserAction>().ReverseMap();

            CreateMap<ClubDescriptionDTO, ClubDescription>().ReverseMap();
            CreateMap<ClubParticipantDTO, ClubParticipant>().ReverseMap();
            CreateMap<ClubRequestDTO, ClubRequest>().ReverseMap();

            CreateMap<SuggestedUserDTO, SuggestedUser>().ReverseMap();

            CreateMap<ChatInformationDTO, ChatInformation>().ReverseMap();

            CreateMap<MessageDTO, Message>().ReverseMap();

            CreateMap<ChatDTO, Chat>().ReverseMap();
        }
    }
}
