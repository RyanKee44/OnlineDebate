namespace OnlineDebate.Domain
{
    public class User : BaseDomainModel
    {
        public string? UserName { get; set; }
        public string? UserGender { get; set; }
        public int UserAge { get; set; }
        public string? UserEmail { get; set; }
        public string? UserBio { get; set; }
    }
}
