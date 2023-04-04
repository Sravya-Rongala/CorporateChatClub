namespace WebApi.Application.DTO.Clubs.ViewModels
{
    public class InActiveClubDTO
    {
        public Guid ClubId { get; set; }
        public string? ClubName { get; set; }
        public string? ClubDescription { get; set; }
        public int ClubType { get; set; }
        public Guid ClubCreatedBy { get; set; }
        public DateTime ClubCreatedOn { get; set; }
        public Guid ClubDeactivatedBy { get; set; }
        public DateTime CLubDeactivatedOn { get; set; }
        public string? Reason { get; set; }
    }
}
