using AutoMapper;
using WebApi.Application.DTO.Users;
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
        /*public IEnumerable<InActiveClub> GetInActiveClubs()
        {
            return _adminRepository.GetInActiveClubs();
        }
        public IEnumerable<AvailableClubs> GetAvailableClubs()
        {
            return _adminRepository.GetAvailableClubs();
        }
        public IEnumerable<UserProfile> GetAllUsers()
        {
            return _adminRepository.GetAllUsers();
        }
        public void UpdateClubActivationStatus(Action action)
        {
            _adminRepository.UpdateClubActivationStatus(action);
        }
        public void DeleteClub(Action action)
        {
            _adminRepository.DeleteClub(action);
        }
        public UserStatus UpdateUserActivationStatus(Action action)
        {
            return _adminRepository.UpdateUserActivationStatus(action);
        }
        public void DeleteUser(Action action)
        {
            _adminRepository.DeleteUser(action);
        }*/
        public Guid AddNewUser(UserDTO newUser)
        {

             return _adminRepository.AddNewUser(_mapper.Map<User>(newUser));
        }
    }
}
