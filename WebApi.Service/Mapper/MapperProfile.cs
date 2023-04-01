using AutoMapper;
using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Application.DTO.Users;
using WebApi.Application.DTO.Users.ViewModels;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels.Users;

namespace WebApi.Service.MapperProfile
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<UserStatusDTO,UserStatus>().ReverseMap();
            CreateMap<UserProfileDTO,UserProfile>().ReverseMap();
            CreateMap<AvailableClubsDTO,AvailableClubs>().ReverseMap();

        }
    }
}
