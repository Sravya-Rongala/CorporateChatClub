using AutoMapper;
using System.Collections.Generic;
using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Application.DTO.Users;
using WebApi.Application.DTO.Users.ViewModels;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels.Users;
using WebApi.Infrastructure.Interfaces;
using WebApi.Interfaces;

namespace WebApi.Service.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        private IMapper _mapper;
        public AdminService(IAdminRepository adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }
        public IEnumerable<InActiveClubDTO> GetInActiveClubs()
        {
            return _mapper.Map<IEnumerable<InActiveClubDTO>>(_adminRepository.GetInActiveClubs());
        }
        public IEnumerable<AvailableClubsDTO> GetAvailableClubs()
        {
            return _mapper.Map<IEnumerable<AvailableClubsDTO>>(_adminRepository.GetAvailableClubs());
        }
        public IEnumerable<UserProfileDTO> GetAllUsers()
        {
            return _mapper.Map<IEnumerable<UserProfileDTO>>(_adminRepository.GetAllUsers());
        }
        /*public void UpdateClubActivationStatus(Action action)
        {
            _adminRepository.UpdateClubActivationStatus(action);
        }
        public UserStatus UpdateUserActivationStatus(ActionUpdater action)
        {
            return _adminRepository.UpdateUserActivationStatus(action);
        }
        public void Delete(ActionUpdater action)
        {
            _adminRepository.Delete(action);
        }*/
        public Guid AddNewUser(UserDTO newUser)
        {
            return _adminRepository.AddNewUser(_mapper.Map<User>(newUser));
        }
    }
}
