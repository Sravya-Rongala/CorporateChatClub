﻿namespace WebApi.Application.DTO.Users
{
    public class SuggestedUser
    {
        public Guid UserId { get; set; }

        public string? UserName { get; set; }

        public string? UserJobTitle { get; set; }

        public string? UserProfilePicture { get; set; }

    }
}
