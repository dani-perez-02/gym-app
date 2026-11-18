using System.Globalization;
using System.Xml.Linq;

namespace gym_app.Plan
{
    internal partial class FrmPlans : Form, IPlanView
    {
        public FrmPlans()
        {
            InitializeComponent();
            ConfigureEvents();
            ConfigureGrid();
        }

        public int PlanId { get; set; }

        public string PlanName
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }

        public string PlanDuration
        {
            get => txtDuration.Text;
            set => txtDuration.Text = value;
        }

        public string PlanPrice
        {
            get => txtPrice.Text;
            set => txtPrice.Text = value;
        }

        public event EventHandler SaveEvent;
        public event EventHandler DisableEvent;
        public event EventHandler ClearEvent;
        public event EventHandler<Plan> PlanSelectedEvent;

        private void ConfigureEvents()
        {
            btnSave.Click += (s, e) => SaveEvent?.Invoke(this, EventArgs.Empty);
            btnDisable.Click += (s, e) => DisableEvent?.Invoke(this, EventArgs.Empty);
            btnClear.Click += (s, e) => ClearEvent?.Invoke(this, EventArgs.Empty);
            dtView.CellClick += dtView_CellClick;
        }

        public void ClearInputs()
        {
            PlanId = 0;
            txtName.Clear();
            txtDuration.Clear();
            txtPrice.Clear();

            txtName.Focus();
        }

        public void DisplayPlans(IEnumerable<Plan> plans)
        {
            dtView.DataSource = plans.ToList();
        }

        public void ShowPlan(Plan plan)
        {
            PlanId = plan.PlanId;
            PlanName = plan.Name;
            PlanDuration = plan.DurationInDays.ToString();
            PlanPrice = plan.Price.ToString();
        }

        public void ShowMessage(string msg, bool isError = false)
        {
            MessageBox.Show(
                msg,
                isError ? "Atención" : "Información",
                MessageBoxButtons.OK,
                isError ? MessageBoxIcon.Warning : MessageBoxIcon.Information
            );
        }

        private void dtView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dtView.Rows[e.RowIndex];
            var plan = (Plan)row.DataBoundItem;

            PlanSelectedEvent?.Invoke(this, plan);
        }

        // para formatear la tabla, que oculte campos que no queremos mostrar y que no este en ingles, formatear el peso chileno etc
        private void ConfigureGrid()
        {
            dtView.AutoGenerateColumns = false;
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtView.Columns.Clear();

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Plan.PlanId),
                HeaderText = "ID",
                Visible = false 
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Plan.Name),
                HeaderText = "Plan",
                FillWeight = 45
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Plan.DurationInDays),
                HeaderText = "Duración (días)",
                FillWeight = 25,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Plan.Price),
                HeaderText = "Precio",
                FillWeight = 30,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C0",
                    FormatProvider = new CultureInfo("es-CL"), 
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }
    }


}