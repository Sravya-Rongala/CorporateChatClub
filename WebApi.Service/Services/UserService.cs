using AutoMapper;
using WebApi.Application.DTO.Users;
using WebApi.Domain.ViewModels.Users;
using WebApi.Infrastructure.Interfaces;
using WebApi.Interfaces;

namespace WebApi.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public UserInformationDTO GetUserInformation(Guid UserId)
        {
            return _mapper.Map<UserInformationDTO>(_userRepository.GetUserInformation(UserId));
        }
        public bool UpdateProfilePicture(Guid UserId, string Picture)
        {
            return _userRepository.UpdateProfilePicture(UserId,Picture);
        }

        public bool UpdatePersonalDetails(Guid UserId,UserPersonalDetailsDTO PersonalDetails)
        {
            return _userRepository.UpdatePersonalDetails(UserId,_mapper.Map<UserPersonalDetails>(PersonalDetails));
        }

        public bool UpdateUserSummary(Guid UserId,string userSummary)
        {
            return _userRepository.UpdateUserSummary(UserId,userSummary);
        }

        public bool UpdateContactDetails(Guid UserId,UserContactDetailsDTO ContactDetails)
        {
            return _userRepository.UpdateContactDetails(UserId,_mapper.Map<UserContactDetails>(ContactDetails));
        }
    }
}
