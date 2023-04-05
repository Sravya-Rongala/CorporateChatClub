using WebApi.Application.DTO.Users;
using WebApi.Domain.ViewModels.Users;

namespace WebApi.Interfaces
{
    public interface IUserService
    {
        public UserInformationDTO GetUserInformation(Guid UserId);

        public bool UpdateProfilePicture(Guid UserId, string picture);

        public bool UpdatePersonalDetails(Guid UserId, UserPersonalDetailsDTO userPersonalDetails);

        public bool UpdateUserSummary(Guid UserId, string userSummary);

        public bool UpdateContactDetails(Guid UserId, UserContactDetailsDTO contactDetails);
    }
}
