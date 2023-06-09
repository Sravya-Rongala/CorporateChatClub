﻿namespace WebApi.Application.DTO.Users.ViewModels
{
    public class UserProfileDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Guid AddedBy { get; set; }
        public DateTime AddedOn { get; set; }
        public int UserStatus { get; set; }
        public int UserRole { get; set; }
        public int ClubCount { get; set; }
    }
}
