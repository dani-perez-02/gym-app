namespace gym_app.Attendance
{
    internal class CheckInResult
    {
        public bool IsAllowed { get; set; }
        public string Title { get; set; } = string.Empty;
        public string MemberName { get; set; } = string.Empty;
        public string Detail { get; set; } = string.Empty;
    }
}