﻿namespace WebApi.Application.DTO.Clubs.ViewModels
{
    public class AvailableClubsDTO
    {
        public Guid ClubId { get; set; }

        public string? ClubName { get; set; }

        public string? ClubProfilePicture { get; set; }
    }
}
