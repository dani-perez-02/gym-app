using gym_app.Configuration;

namespace gym_app.Membership
{
    internal partial class FrmMemberships : Form, IMembershipView
    {
        public FrmMemberships()
        {
            InitializeComponent();
            ConfigureGrid();
            ConfigureEvents();
        }

        public int MembershipId { get; set; }

        public int SelectedMemberId
        {
            get => cmbMember.SelectedValue is int id ? id : 0;
            set => cmbMember.SelectedValue = value;
        }

        public int SelectedPlanId
        {
            get => cmbPlan.SelectedValue is int id ? id : 0;
            set => cmbPlan.SelectedValue = value;
        }

        public DateTime StartDate
        {
            get => dtpStartDate.Value.Date;
            set => dtpStartDate.Value = value;
        }

        public string EndDatePreview
        {
            set => txtEndDate.Text = value;
        }

        public event EventHandler SaveEvent;
        public event EventHandler CancelMembershipEvent;
        public event EventHandler ClearEvent;
        public event EventHandler PlanOrDateChangedEvent;
        public event EventHandler<Membership> MembershipSelectedEvent;

        private void ConfigureGrid()
        {
            dtView.AutoGenerateColumns = false;
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtView.Columns.Clear();

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Membership.MembershipId),
                HeaderText = "ID",
                Visible = false
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Membership.MemberRut),
                HeaderText = "RUT",
                FillWeight = 16
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Membership.MemberName),
                HeaderText = "Socio",
                FillWeight = 26
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Membership.PlanName),
                HeaderText = "Plan",
                FillWeight = 20
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Membership.StartDate),
                HeaderText = "Inicio",
                FillWeight = 13,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Membership.EndDate),
                HeaderText = "Término",
                FillWeight = 13,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Membership.Status),
                HeaderText = "Estado",
                FillWeight = 12,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });
            GridStyler.Apply(dtView);
        }

        private void ConfigureEvents()
        {
            btnSave.Click += (s, e) => SaveEvent?.Invoke(this, EventArgs.Empty);
            btnCancel.Click += (s, e) => CancelMembershipEvent?.Invoke(this, EventArgs.Empty);
            btnClear.Click += (s, e) => ClearEvent?.Invoke(this, EventArgs.Empty);
            cmbPlan.SelectedIndexChanged += (s, e) => PlanOrDateChangedEvent?.Invoke(this, EventArgs.Empty);
            dtpStartDate.ValueChanged += (s, e) => PlanOrDateChangedEvent?.Invoke(this, EventArgs.Empty);
            dtView.CellClick += dtView_CellClick;
        }

        public void LoadMembers(IEnumerable<Member.Member> members)
        {
            cmbMember.DataSource = null;
            cmbMember.DisplayMember = nameof(Member.Member.Name);
            cmbMember.ValueMember = nameof(Member.Member.MemberId);
            cmbMember.DataSource = members.ToList();
        }

        public void LoadPlans(IEnumerable<Plan.Plan> plans)
        {
            cmbPlan.DataSource = null;
            cmbPlan.DisplayMember = nameof(Plan.Plan.Name);
            cmbPlan.ValueMember = nameof(Plan.Plan.PlanId);
            cmbPlan.DataSource = plans.ToList();
        }

        public void DisplayMemberships(IEnumerable<Membership> memberships)
        {
            dtView.DataSource = memberships.ToList();
        }

        public void ShowMembership(Membership membership)
        {
            MembershipId = membership.MembershipId;
            SelectedMemberId = membership.MemberId;
            SelectedPlanId = membership.PlanId;
            StartDate = membership.StartDate;
            EndDatePreview = membership.EndDate.ToString("dd/MM/yyyy");
        }

        public void ClearInputs()
        {
            MembershipId = 0;
            if (cmbMember.Items.Count > 0) cmbMember.SelectedIndex = 0;
            if (cmbPlan.Items.Count > 0) cmbPlan.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Today;
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
            var membership = (Membership)row.DataBoundItem;

            MembershipSelectedEvent?.Invoke(this, membership);
        }
    }
}