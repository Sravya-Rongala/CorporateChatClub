﻿namespace WebApi.Domain.ViewModels.Users
{
    public class UserProfile
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
