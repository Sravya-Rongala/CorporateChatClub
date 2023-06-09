﻿using WebApi.Domain.ViewModels.Clubs;

namespace WebApi.Application.DTO.Clubs
{
    public class ClubDetails
    {
        public ClubDescription? ClubDescription { get; set; }

        public List<ClubParticipant>? ClubParticipants { get; set; }

        public List<ClubRequest>? ClubRequests { get; set; }
    }
}
