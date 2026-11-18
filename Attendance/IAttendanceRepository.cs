namespace gym_app.Attendance
{
    internal interface IAttendanceRepository
    {
        void Save(int memberId);
        IEnumerable<Attendance> GetTodayAttendance();
    }
}