namespace gym_app.Attendance
{
    internal class AttendancePresenter
    {
        private readonly AttendanceService _service;
        private readonly IAttendanceView _view;

        public AttendancePresenter(AttendanceService service, IAttendanceView view)
        {
            _service = service;
            _view = view;

            _view.CheckInEvent += OnCheckIn;

            LoadTodayAttendance();
        }

        private void LoadTodayAttendance()
        {
            try
            {
                _view.DisplayTodayAttendance(_service.GetTodayAttendance());
            }
            catch (Exception ex)
            {
                _view.ShowError($"Error al cargar asistencias de hoy: {ex.Message}");
            }
        }

        private void OnCheckIn(object? sender, EventArgs e)
        {
            try
            {
                var result = _service.RegisterCheckIn(_view.RutInput);
                _view.ShowCheckInResult(result);
                _view.ResetInput();

                if (result.IsAllowed)
                    LoadTodayAttendance();
            }
            catch (Exception ex)
            {
                _view.ShowError($"Error al registrar ingreso: {ex.Message}");
            }
        }
    }
}