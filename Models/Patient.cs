namespace NiceClinic.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "New Patient";
        public string NationalId { get; set; } = "";
        public string Email { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public DateTime? DateOfBirth { get; set; }
    }
}
