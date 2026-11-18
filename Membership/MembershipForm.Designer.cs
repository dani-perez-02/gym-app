namespace gym_app.Membership
{
    partial class FrmMemberships
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelCard = new Panel();
            flowInputs = new FlowLayoutPanel();
            lblCardTitle = new Label();
            lblMember = new Label();
            cmbMember = new ComboBox();
            lblPlan = new Label();
            cmbPlan = new ComboBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            txtEndDate = new TextBox();
            panelRowButtons = new Panel();
            btnClear = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            panelGridContainer = new Panel();
            dtView = new DataGridView();
            panelCard.SuspendLayout();
            flowInputs.SuspendLayout();
            panelRowButtons.SuspendLayout();
            panelGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.White;
            panelCard.Controls.Add(flowInputs);
            panelCard.Dock = DockStyle.Left;
            panelCard.Location = new Point(0, 0);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(16);
            panelCard.Size = new Size(320, 580);
            panelCard.TabIndex = 0;
            // 
            // flowInputs
            // 
            flowInputs.AutoScroll = true;
            flowInputs.Controls.Add(lblCardTitle);
            flowInputs.Controls.Add(lblMember);
            flowInputs.Controls.Add(cmbMember);
            flowInputs.Controls.Add(lblPlan);
            flowInputs.Controls.Add(cmbPlan);
            flowInputs.Controls.Add(lblStartDate);
            flowInputs.Controls.Add(dtpStartDate);
            flowInputs.Controls.Add(lblEndDate);
            flowInputs.Controls.Add(txtEndDate);
            flowInputs.Controls.Add(panelRowButtons);
            flowInputs.Controls.Add(btnCancel);
            flowInputs.Dock = DockStyle.Fill;
            flowInputs.FlowDirection = FlowDirection.TopDown;
            flowInputs.Location = new Point(16, 16);
            flowInputs.Margin = new Padding(0);
            flowInputs.Name = "flowInputs";
            flowInputs.Size = new Size(288, 548);
            flowInputs.TabIndex = 0;
            flowInputs.WrapContents = false;
            // 
            // lblCardTitle
            // 
            lblCardTitle.AutoSize = true;
            lblCardTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardTitle.ForeColor = Color.FromArgb(32, 42, 34);
            lblCardTitle.Location = new Point(0, 0);
            lblCardTitle.Margin = new Padding(0, 0, 0, 16);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(145, 20);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Nueva Suscripción";
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.ForeColor = Color.FromArgb(102, 112, 133);
            lblMember.Location = new Point(0, 36);
            lblMember.Margin = new Padding(0, 0, 0, 4);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(40, 15);
            lblMember.TabIndex = 1;
            lblMember.Text = "Socio:";
            // 
            // cmbMember
            // 
            cmbMember.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMember.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(0, 55);
            cmbMember.Margin = new Padding(0, 0, 0, 14);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(270, 25);
            cmbMember.TabIndex = 2;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.ForeColor = Color.FromArgb(102, 112, 133);
            lblPlan.Location = new Point(0, 94);
            lblPlan.Margin = new Padding(0, 0, 0, 4);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(33, 15);
            lblPlan.TabIndex = 3;
            lblPlan.Text = "Plan:";
            // 
            // cmbPlan
            // 
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Location = new Point(0, 113);
            cmbPlan.Margin = new Padding(0, 0, 0, 14);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(270, 25);
            cmbPlan.TabIndex = 4;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.ForeColor = Color.FromArgb(102, 112, 133);
            lblStartDate.Location = new Point(0, 152);
            lblStartDate.Margin = new Padding(0, 0, 0, 4);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(91, 15);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "Fecha de Inicio:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.Location = new Point(0, 171);
            dtpStartDate.Margin = new Padding(0, 0, 0, 14);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(270, 25);
            dtpStartDate.TabIndex = 6;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.ForeColor = Color.FromArgb(102, 112, 133);
            lblEndDate.Location = new Point(0, 210);
            lblEndDate.Margin = new Padding(0, 0, 0, 4);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(140, 15);
            lblEndDate.TabIndex = 7;
            lblEndDate.Text = "Fecha de Término (auto):";
            // 
            // txtEndDate
            // 
            txtEndDate.BackColor = Color.FromArgb(246, 247, 244);
            txtEndDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEndDate.Location = new Point(0, 229);
            txtEndDate.Margin = new Padding(0, 0, 0, 14);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(270, 25);
            txtEndDate.TabIndex = 8;
            // 
            // panelRowButtons
            // 
            panelRowButtons.BackColor = Color.Transparent;
            panelRowButtons.Controls.Add(btnClear);
            panelRowButtons.Controls.Add(btnSave);
            panelRowButtons.Location = new Point(0, 268);
            panelRowButtons.Margin = new Padding(0, 0, 0, 10);
            panelRowButtons.Name = "panelRowButtons";
            panelRowButtons.Size = new Size(270, 38);
            panelRowButtons.TabIndex = 9;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(229, 231, 235);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(32, 42, 34);
            btnClear.Location = new Point(140, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 38);
            btnClear.TabIndex = 1;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(77, 124, 15);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Registrar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(183, 121, 121);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(0, 320);
            btnCancel.Margin = new Padding(0, 4, 0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(270, 34);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancelar Suscripción";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // panelGridContainer
            // 
            panelGridContainer.BackColor = Color.FromArgb(246, 247, 244);
            panelGridContainer.Controls.Add(dtView);
            panelGridContainer.Dock = DockStyle.Fill;
            panelGridContainer.Location = new Point(320, 0);
            panelGridContainer.Name = "panelGridContainer";
            panelGridContainer.Padding = new Padding(16);
            panelGridContainer.Size = new Size(580, 580);
            panelGridContainer.TabIndex = 1;
            // 
            // dtView
            // 
            dtView.AllowUserToAddRows = false;
            dtView.AllowUserToDeleteRows = false;
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtView.BackgroundColor = Color.White;
            dtView.BorderStyle = BorderStyle.None;
            dtView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtView.Dock = DockStyle.Fill;
            dtView.EnableHeadersVisualStyles = false;
            dtView.Location = new Point(16, 16);
            dtView.MultiSelect = false;
            dtView.Name = "dtView";
            dtView.ReadOnly = true;
            dtView.RowHeadersVisible = false;
            dtView.RowTemplate.Height = 34;
            dtView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtView.Size = new Size(548, 548);
            dtView.TabIndex = 0;
            // 
            // FrmMemberships
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(900, 580);
            Controls.Add(panelGridContainer);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMemberships";
            Text = "Gestión de Suscripciones";
            panelCard.ResumeLayout(false);
            flowInputs.ResumeLayout(false);
            flowInputs.PerformLayout();
            panelRowButtons.ResumeLayout(false);
            panelGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCard;
        private FlowLayoutPanel flowInputs;
        private Label lblCardTitle;
        private Label lblMember;
        private ComboBox cmbMember;
        private Label lblPlan;
        private ComboBox cmbPlan;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblEndDate;
        private TextBox txtEndDate;
        private Panel panelRowButtons;
        private Button btnClear;
        private Button btnSave;
        private Button btnCancel;
        private Panel panelGridContainer;
        private DataGridView dtView;
    }
}