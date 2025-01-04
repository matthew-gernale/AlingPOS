
namespace AlingPOS.Shared.Models.Auth
{
    public class UserDetail
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
        public string AttendancePin { get; set; } = string.Empty;
        public User User { get; set; }
        public Guid UserId { get; set; }

        [JsonIgnore]
        public List<EmpAttendance>? Attendances { get; set; }
    }
}
