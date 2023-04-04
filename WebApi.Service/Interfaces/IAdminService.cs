﻿using WebApi.Application.DTO;
using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Application.DTO.Users;
using WebApi.Application.DTO.Users.ViewModels;
using WebApi.Domain.ViewModels;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels.Users;

namespace WebApi.Interfaces
{
    public interface IAdminService
    {
        public IEnumerable<InActiveClubDTO> GetInActiveClubs();
        public IEnumerable<AvailableClubsDTO> GetAvailableClubs();
        public IEnumerable<UserProfileDTO> GetAllUsers();
        public void UpdateActivationStatus(ActionUpdaterDTO action);
        public void Delete(ActionUpdaterDTO action);
        public Guid AddNewUser(UserDTO newUser);

    }
}
