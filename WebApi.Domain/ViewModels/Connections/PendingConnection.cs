namespace WebApi.Domain.ViewModels.Connections
{
    public class PendingConnection
    {
        public string? Name { get; set; }
        public string? ProfilePic { get; set; }
        public string? ActionTaken { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int MutualCount { get; set; }
        /*public List<string>? MutualNames { get; set; }*/
        public int RequestStatus { get; set; }
    }
}
