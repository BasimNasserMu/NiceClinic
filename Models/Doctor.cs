namespace NiceClinic.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Specialty { get; set; }
        public AppUser? User { get; set; }
    }
}
