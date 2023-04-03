using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Application.DTO.Users;
using WebApi.Application.DTO.Users.ViewModels;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels.Users;

namespace WebApi.Interfaces
{
    public interface IAdminService
    {
        public IEnumerable<InActiveClubDTO> GetInActiveClubs();
        public IEnumerable<AvailableClubsDTO> GetAvailableClubs();
        public IEnumerable<UserProfileDTO> GetAllUsers();
       /* public void UpdateClubActivationStatus(Action action);
        public UserStatus UpdateUserActivationStatus(Action action);
        public void Delete(Action action);*/
        public Guid AddNewUser(UserDTO newUser);

    }
}
