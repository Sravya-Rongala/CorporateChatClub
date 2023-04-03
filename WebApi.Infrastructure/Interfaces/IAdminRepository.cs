using WebApi.Application.DTO.Users;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels.Users;

namespace WebApi.Infrastructure.Interfaces
{
    public interface IAdminRepository
    {
        public IEnumerable<InActiveClub> GetInActiveClubs();
        public IEnumerable<UserProfile> GetAllUsers();
        public IEnumerable<AvailableClubs> GetAvailableClubs();
       /* public void UpdateClubActivationStatus(Action action);
        public UserStatus UpdateUserActivationStatus(Action action);
        public void Delete(Action action);*/
        public Guid AddNewUser(User newUser);
    }
}
