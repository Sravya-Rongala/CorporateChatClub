﻿using AutoMapper;
using WebApi.Application.DTO;
using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Application.DTO.Users;
using WebApi.Application.DTO.Users.ViewModels;
using WebApi.Domain.ViewModels;
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

        public void UpdateActivationStatus(ActionUpdaterDTO action)
        {
            if (action.IsClub == true)
            {
                _adminRepository.UpdateClubActivationStatus(_mapper.Map<ActionUpdater>(action));
            }
            else
            {
                _adminRepository.UpdateUserActivationStatus(_mapper.Map<ActionUpdater>(action));
            }

        }
        public void Delete(ActionUpdaterDTO action)
        {

            if (action.IsClub == true)
            {
                _adminRepository.DeleteClub(_mapper.Map<ActionUpdater>(action));
            }
            else
            {
                _adminRepository.DeleteUser(_mapper.Map<ActionUpdater>(action));
            }
        }
        public Guid AddNewUser(UserDTO newUser)
        {

            return _adminRepository.AddNewUser(_mapper.Map<User>(newUser));
        }
    }
}