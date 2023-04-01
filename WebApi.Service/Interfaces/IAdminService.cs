﻿using WebApi.Application.DTO.Users;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels.Users;

namespace WebApi.Interfaces
{
    public interface IAdminService
    {
       /* public IEnumerable<InActiveClub> GetInActiveClubs();
        public IEnumerable<AvailableClubs> GetAvailableClubs();
        public IEnumerable<UserProfile> GetAllUsers();
        public void UpdateClubActivationStatus(Action action);
        public void DeleteClub(Action action);
        public UserStatus UpdateUserActivationStatus(Action action);
        public void DeleteUser(Action action);*/
        public Guid AddNewUser(UserDTO newUser );

    }
}
