namespace gym_app.Attendance
{
    internal class Attendance
    {
        public int AttendanceId { get; set; }
        public int MemberId { get; set; }
        public DateTime EntranceDateTime { get; set; }

        // pal join
        public string MemberRut { get; set; } = string.Empty;
        public string MemberName { get; set; } = string.Empty;
        public string PlanName { get; set; } = string.Empty;
    }
}