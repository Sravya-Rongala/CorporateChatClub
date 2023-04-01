using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels.Users;

namespace WebApi1.Interfaces
{
    public interface IAdminService
    {
        public IEnumerable<InActiveClub> GetInActiveClubs();
        public IEnumerable<UserProfile> GetAllUsers();
        public IEnumerable<AvailableClubs> GetAvailableClubs();
        public void UpdateClubActivationStatus(Action action);
        public void DeleteClub(Action action);
        public void UpdateUserActivationStatus(Action action);
        public void DeleteUser(Action action);
        public Guid AddNewUser(User newUser );

    }
}
