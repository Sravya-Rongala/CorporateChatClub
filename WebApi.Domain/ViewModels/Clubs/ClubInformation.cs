﻿namespace WebApi.Domain.ViewModels.Clubs
{
    public class ClubInformation
    {
        public Guid ClubId { get; set; }

        public string? ClubName { get; set; }

        public bool IsClubNameModified { get; set; }

        public string? ClubDescription { get; set; }

        public bool IsClubDescriptionModified { get; set; }

        public string? ClubProfilePicture { get; set; }

        public bool IsClubPictureModified { get; set; }
    }
}