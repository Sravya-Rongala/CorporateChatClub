namespace WebApi.Application.DTO.Users
{
    public class UserBasicDetails
    {
        public Guid UserId { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }
        public string? About { get; set; }

        public string? PhoneNumeber { get; set; }

        public string? Summary { get; set; }

    }

}
