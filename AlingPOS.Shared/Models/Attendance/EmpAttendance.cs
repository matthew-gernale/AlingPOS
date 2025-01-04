
namespace AlingPOS.Shared.Models.Attendance
{
    public class EmpAttendance
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public AttendanceState AttendanceState { get; set; }
        public DateTime AttendanceDate { get; set; } = DateTime.Now;
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public DateTime? LunchIn { get; set; }
        public DateTime? LunchOut { get; set; }
        public string TimeInImage { get; set; } = string.Empty;
        public string TimeOutImage { get; set; } = string.Empty;
        public UserDetail UserDetails { get; set; }
        public int UserDetailId { get; set; }
    }
}
