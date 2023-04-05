using WebApi.Domain.ViewModels;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels.Users;

namespace WebApi.Infrastructure.Interfaces
{
    public interface IAdminRepository
    {
        public IEnumerable<InActiveClub> GetInActiveClubs();
        public IEnumerable<UserProfile> GetAllUsers();
        public IEnumerable<AvailableClubs> GetAvailableClubs();
        public void UpdateClubActivationStatus(ActionUpdater action);

        public void UpdateUserActivationStatus(ActionUpdater action);

/*        public UserStatus UpdateUserActivationStatus(Action action);*/
        public void DeleteClub(ActionUpdater action);
        public void DeleteUser(ActionUpdater action);
        public Guid AddNewUser(User newUser);
    }
}
