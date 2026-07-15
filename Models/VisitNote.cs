namespace NiceClinic.Models
{
    public class VisitNote
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public string Notes { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Appointment? Appointment { get; set; }
    }
}
