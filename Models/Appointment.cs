namespace NiceClinic.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string UserId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Patient? Patient { get; set; }
        public Doctor? Doctor { get; set; }
        public AppUser? User { get; set; }


    }
}
