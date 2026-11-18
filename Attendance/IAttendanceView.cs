namespace gym_app.Attendance
{
    internal interface IAttendanceView
    {
        string RutInput { get; set; }

        event EventHandler CheckInEvent;

        void DisplayTodayAttendance(IEnumerable<Attendance> attendances);
        void ShowCheckInResult(CheckInResult result);
        void ShowError(string message);
        void ResetInput();
    }
}