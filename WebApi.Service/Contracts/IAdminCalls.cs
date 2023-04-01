using WebApi.Application.DTO.Clubs;
using WebApi1.Application.DTO;

namespace WebApi1.Interfaces
{
    public interface IAdminCalls
    {
        public IEnumerable<WebApi.Application.DTO.Clubs.InActiveClub> GetInActiveClubs();
        public void ReactiveClub(Application.DTO.Action a);
        public void DeactivateClub(Application.DTO.Action a);
        public void DeleteClub(Application.DTO.Action a);
        public IEnumerable<UserAdminView> GetAllUsers();
        public WebApi.Application.DTO.Users.User ReactivateUser(Application.DTO.Action a);
        public WebApi.Application.DTO.Users.User DeactivateUser(Application.DTO.Action a);
        public void DeleteUser(Application.DTO.Action a);
        public WebApi.Application.DTO.Users.User AddNewUser(WebApi.Application.DTO.Users.AddUser newUser);
        public IEnumerable<AvailableClubs> GetAvailableClubs();

    }
}
