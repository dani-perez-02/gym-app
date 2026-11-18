using gym_app.Configuration;

namespace gym_app.Attendance
{
    internal partial class FrmAttendance : Form, IAttendanceView
    {
        private readonly Color ColorAllowed = ColorTranslator.FromHtml("#26532B");
        private readonly Color ColorDenied = ColorTranslator.FromHtml("#BF211E");

        public FrmAttendance()
        {
            InitializeComponent();
            ConfigureGrid();
            ConfigureEvents();
        }

        public string RutInput
        {
            get => txtRut.Text;
            set => txtRut.Text = value;
        }

        public event EventHandler CheckInEvent;

        private void ConfigureGrid()
        {
            dtView.AutoGenerateColumns = false;
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtView.Columns.Clear();

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Attendance.EntranceDateTime),
                HeaderText = "Hora",
                FillWeight = 18,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "HH:mm",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Attendance.MemberRut),
                HeaderText = "RUT",
                FillWeight = 22
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Attendance.MemberName),
                HeaderText = "Socio",
                FillWeight = 35
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Attendance.PlanName),
                HeaderText = "Plan",
                FillWeight = 25
            });
            GridStyler.Apply(dtView);
        }

        private void ConfigureEvents()
        {
            btnCheckIn.Click += (s, e) => CheckInEvent?.Invoke(this, EventArgs.Empty);

            // pal beep del enter en textbox
            txtRut.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    CheckInEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            // shown es un evento de la ventana que se dispara cuando se muestra la ventana pr 1ra vez
            Shown += (s, e) => txtRut.Focus();
        }

        public void DisplayTodayAttendance(IEnumerable<Attendance> attendances)
        {
            dtView.DataSource = attendances.ToList();
        }

        public void ShowCheckInResult(CheckInResult result)
        {
            panelStatus.BackColor = result.IsAllowed ? ColorAllowed : ColorDenied;
            lblStatusTitle.ForeColor = Color.White;
            lblStatusMember.ForeColor = Color.White;
            lblStatusDetail.ForeColor = Color.FromArgb(235, 235, 235);

            lblStatusTitle.Text = result.Title;
            lblStatusMember.Text = result.MemberName;
            lblStatusDetail.Text = result.Detail;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ResetInput()
        {
            txtRut.Clear();
            txtRut.Focus();
        }
    }
}