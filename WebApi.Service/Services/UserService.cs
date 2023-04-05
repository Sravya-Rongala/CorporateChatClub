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

        public bool IsUserExist(Guid UserId)
        {
            return _userRepository.IsUserExist(UserId);
        }
        public UserInformationDTO GetUserInformation(Guid UserId)
        {
            return _mapper.Map<UserInformationDTO>(_userRepository.GetUserInformation(UserId));
        }
        public bool UpdateProfilePicture(Guid UserId, string Picture)
        {
            if (this.IsUserExist(UserId))
            {
                return _userRepository.UpdateProfilePicture(UserId, Picture);
            }
            return false;
        }

        public bool UpdatePersonalDetails(Guid UserId,UserPersonalDetailsDTO PersonalDetails)
        {
            if (this.IsUserExist(UserId))
            {
                return _userRepository.UpdatePersonalDetails(UserId, _mapper.Map<UserPersonalDetails>(PersonalDetails));
            }
            return false;
        }

        public bool UpdateUserSummary(Guid UserId,string userSummary)
        {
            if (this.IsUserExist(UserId))
            {
                return _userRepository.UpdateUserSummary(UserId, userSummary);
            }
            return false;
        }

        public bool UpdateContactDetails(Guid UserId,UserContactDetailsDTO ContactDetails)
        {
            if (this.IsUserExist(UserId))
            {
                return _userRepository.UpdateContactDetails(UserId, _mapper.Map<UserContactDetails>(ContactDetails));
            }
            return false;
        }
    }
}
