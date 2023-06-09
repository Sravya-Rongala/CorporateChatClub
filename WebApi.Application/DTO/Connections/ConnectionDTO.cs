﻿namespace WebApi.Application.DTO.Connections
{
    public class ConnectionDTO
    {
        public Guid UserId { get; set; }

        public string? Name { get; set; }

        public string? About { get; set; }

        public int MutualCount { get; set; }

        public string? Email { get; set; }

        public string? ProfilePicture { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
