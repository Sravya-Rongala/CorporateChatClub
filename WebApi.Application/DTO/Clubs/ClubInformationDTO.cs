namespace WebApi.Application.DTO.Clubs
{
    public class ClubInformationDTO
    {
        public Guid ClubId { get; set; }

        public Guid UserId { get; set; }
        public string? ClubName { get; set; }

        public string? ClubDescription { get; set; }

        public string? ClubProfilePicture { get; set; }
    }
}
