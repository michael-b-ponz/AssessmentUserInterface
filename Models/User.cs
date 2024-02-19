namespace AssessmentUserInterface.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string EmailAddress { get; set; } = "";
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
