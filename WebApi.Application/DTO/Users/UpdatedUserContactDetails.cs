namespace WebApi.Application.DTO.Users
{
    public class UpdatedUserContactDetails
    {
        public int Id { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public string? AddressLine1 { get; set; }

        public string? AddressLine2 { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? ZipCode { get; set; }
    }
}
