using WebApi.Application.DTO.Clubs.ViewModels;

namespace WebApi.Application.DTO.Clubs
{
    public class ClubDetailsDTO
    {
        public ClubDescriptionDTO? ClubDescription { get; set; }

        public List<ClubParticipantDTO>? ClubParticipants { get; set; }

        public List<ClubRequestDTO>? ClubRequests { get; set; }
    }
}
