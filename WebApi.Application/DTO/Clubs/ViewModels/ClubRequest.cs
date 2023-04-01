﻿namespace WebApi.Application.DTO.Clubs.ViewModels
{
    public class ClubRequest
    {
        public Guid RequestedUserId { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? ProfilePicture { get; set; }
    }
}
