namespace gym_app.Attendance
{
    partial class FrmAttendance
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
            lblRut = new Label();
            txtRut = new TextBox();
            btnCheckIn = new Button();
            panelStatus = new Panel();
            lblStatusTitle = new Label();
            lblStatusMember = new Label();
            lblStatusDetail = new Label();
            panelGridContainer = new Panel();
            lblGridTitle = new Label();
            dtView = new DataGridView();
            panelCard.SuspendLayout();
            flowInputs.SuspendLayout();
            panelStatus.SuspendLayout();
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
            flowInputs.Controls.Add(lblRut);
            flowInputs.Controls.Add(txtRut);
            flowInputs.Controls.Add(btnCheckIn);
            flowInputs.Controls.Add(panelStatus);
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
            lblCardTitle.Size = new Size(138, 20);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Control de Acceso";
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.ForeColor = Color.FromArgb(102, 112, 133);
            lblRut.Location = new Point(0, 36);
            lblRut.Margin = new Padding(0, 0, 0, 6);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(140, 15);
            lblRut.TabIndex = 1;
            lblRut.Text = "RUT del Socio (Enter):";
            // 
            // txtRut
            // 
            txtRut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRut.Location = new Point(0, 57);
            txtRut.Margin = new Padding(0, 0, 0, 14);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(270, 29);
            txtRut.TabIndex = 2;
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = Color.FromArgb(77, 124, 15);
            btnCheckIn.Cursor = Cursors.Hand;
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckIn.ForeColor = Color.White;
            btnCheckIn.Location = new Point(0, 100);
            btnCheckIn.Margin = new Padding(0, 0, 0, 20);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(270, 42);
            btnCheckIn.TabIndex = 3;
            btnCheckIn.Text = "Registrar Ingreso";
            btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.FromArgb(241, 243, 239);
            panelStatus.Controls.Add(lblStatusDetail);
            panelStatus.Controls.Add(lblStatusMember);
            panelStatus.Controls.Add(lblStatusTitle);
            panelStatus.Location = new Point(0, 162);
            panelStatus.Margin = new Padding(0);
            panelStatus.Name = "panelStatus";
            panelStatus.Padding = new Padding(14);
            panelStatus.Size = new Size(270, 130);
            panelStatus.TabIndex = 4;
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusTitle.ForeColor = Color.FromArgb(102, 112, 133);
            lblStatusTitle.Location = new Point(14, 14);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(135, 19);
            lblStatusTitle.TabIndex = 0;
            lblStatusTitle.Text = "Esperando ingreso...";
            // 
            // lblStatusMember
            // 
            lblStatusMember.AutoSize = false;
            lblStatusMember.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusMember.ForeColor = Color.FromArgb(32, 42, 34);
            lblStatusMember.Location = new Point(14, 42);
            lblStatusMember.Name = "lblStatusMember";
            lblStatusMember.Size = new Size(242, 24);
            lblStatusMember.TabIndex = 1;
            lblStatusMember.Text = "";
            // 
            // lblStatusDetail
            // 
            lblStatusDetail.AutoSize = false;
            lblStatusDetail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusDetail.ForeColor = Color.FromArgb(102, 112, 133);
            lblStatusDetail.Location = new Point(14, 70);
            lblStatusDetail.Name = "lblStatusDetail";
            lblStatusDetail.Size = new Size(242, 46);
            lblStatusDetail.TabIndex = 2;
            lblStatusDetail.Text = "Ingrese el RUT y presione Enter para validar la suscripción.";
            // 
            // panelGridContainer
            // 
            panelGridContainer.BackColor = Color.FromArgb(246, 247, 244);
            panelGridContainer.Controls.Add(dtView);
            panelGridContainer.Controls.Add(lblGridTitle);
            panelGridContainer.Dock = DockStyle.Fill;
            panelGridContainer.Location = new Point(320, 0);
            panelGridContainer.Name = "panelGridContainer";
            panelGridContainer.Padding = new Padding(16);
            panelGridContainer.Size = new Size(580, 580);
            panelGridContainer.TabIndex = 1;
            // 
            // lblGridTitle
            // 
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGridTitle.ForeColor = Color.FromArgb(32, 42, 34);
            lblGridTitle.Location = new Point(16, 16);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Padding = new Padding(0, 0, 0, 8);
            lblGridTitle.Size = new Size(548, 30);
            lblGridTitle.TabIndex = 1;
            lblGridTitle.Text = "Ingresos de Hoy";
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
            dtView.Location = new Point(16, 46);
            dtView.MultiSelect = false;
            dtView.Name = "dtView";
            dtView.ReadOnly = true;
            dtView.RowHeadersVisible = false;
            dtView.RowTemplate.Height = 34;
            dtView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtView.Size = new Size(548, 518);
            dtView.TabIndex = 0;
            // 
            // FrmAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(900, 580);
            Controls.Add(panelGridContainer);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAttendance";
            Text = "Gestión de Asistencia";
            panelCard.ResumeLayout(false);
            flowInputs.ResumeLayout(false);
            flowInputs.PerformLayout();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            panelGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCard;
        private FlowLayoutPanel flowInputs;
        private Label lblCardTitle;
        private Label lblRut;
        private TextBox txtRut;
        private Button btnCheckIn;
        private Panel panelStatus;
        private Label lblStatusTitle;
        private Label lblStatusMember;
        private Label lblStatusDetail;
        private Panel panelGridContainer;
        private Label lblGridTitle;
        private DataGridView dtView;
    }
}