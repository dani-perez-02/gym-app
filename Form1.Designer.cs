namespace gym_app
{
    partial class GymApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymApp));
            panelSidebar = new Panel();
            btnNavStats = new Button();
            btnNavPayments = new Button();
            btnNavAttendance = new Button();
            btnNavSubcriptions = new Button();
            btnNavPlans = new Button();
            btnNavMembers = new Button();
            panelLogo = new Panel();
            picLogo = new PictureBox();
            panelHeader = new Panel();
            lblHeader = new Label();
            panelContent = new Panel();
            panelSidebar.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(28, 32, 38);
            panelSidebar.Controls.Add(btnNavStats);
            panelSidebar.Controls.Add(btnNavPayments);
            panelSidebar.Controls.Add(btnNavAttendance);
            panelSidebar.Controls.Add(btnNavSubcriptions);
            panelSidebar.Controls.Add(btnNavPlans);
            panelSidebar.Controls.Add(btnNavMembers);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(240, 611);
            panelSidebar.TabIndex = 0;
            // 
            // btnNavStats
            // 
            btnNavStats.Cursor = Cursors.Hand;
            btnNavStats.Dock = DockStyle.Top;
            btnNavStats.FlatAppearance.BorderSize = 0;
            btnNavStats.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 48, 56);
            btnNavStats.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 48, 56);
            btnNavStats.FlatStyle = FlatStyle.Flat;
            btnNavStats.Font = new Font("Segoe UI", 9.75F);
            btnNavStats.ForeColor = Color.Silver;
            btnNavStats.Location = new Point(0, 360);
            btnNavStats.Name = "btnNavStats";
            btnNavStats.Padding = new Padding(10, 0, 0, 0);
            btnNavStats.Size = new Size(240, 55);
            btnNavStats.TabIndex = 6;
            btnNavStats.Text = "📊  Estadísticas";
            btnNavStats.TextAlign = ContentAlignment.MiddleLeft;
            btnNavStats.UseVisualStyleBackColor = true;
            // 
            // btnNavPayments
            // 
            btnNavPayments.Cursor = Cursors.Hand;
            btnNavPayments.Dock = DockStyle.Top;
            btnNavPayments.FlatAppearance.BorderSize = 0;
            btnNavPayments.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 48, 56);
            btnNavPayments.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 48, 56);
            btnNavPayments.FlatStyle = FlatStyle.Flat;
            btnNavPayments.Font = new Font("Segoe UI", 9.75F);
            btnNavPayments.ForeColor = Color.Silver;
            btnNavPayments.Location = new Point(0, 305);
            btnNavPayments.Name = "btnNavPayments";
            btnNavPayments.Padding = new Padding(10, 0, 0, 0);
            btnNavPayments.Size = new Size(240, 55);
            btnNavPayments.TabIndex = 5;
            btnNavPayments.Text = "💰  Pagos";
            btnNavPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnNavPayments.UseVisualStyleBackColor = true;
            // 
            // btnNavAttendance
            // 
            btnNavAttendance.Cursor = Cursors.Hand;
            btnNavAttendance.Dock = DockStyle.Top;
            btnNavAttendance.FlatAppearance.BorderSize = 0;
            btnNavAttendance.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 48, 56);
            btnNavAttendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 48, 56);
            btnNavAttendance.FlatStyle = FlatStyle.Flat;
            btnNavAttendance.Font = new Font("Segoe UI", 9.75F);
            btnNavAttendance.ForeColor = Color.Silver;
            btnNavAttendance.Location = new Point(0, 250);
            btnNavAttendance.Name = "btnNavAttendance";
            btnNavAttendance.Padding = new Padding(10, 0, 0, 0);
            btnNavAttendance.Size = new Size(240, 55);
            btnNavAttendance.TabIndex = 4;
            btnNavAttendance.Text = "✔️  Asistencia";
            btnNavAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnNavAttendance.UseVisualStyleBackColor = true;
            // 
            // btnNavSubcriptions
            // 
            btnNavSubcriptions.Cursor = Cursors.Hand;
            btnNavSubcriptions.Dock = DockStyle.Top;
            btnNavSubcriptions.FlatAppearance.BorderSize = 0;
            btnNavSubcriptions.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 48, 56);
            btnNavSubcriptions.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 48, 56);
            btnNavSubcriptions.FlatStyle = FlatStyle.Flat;
            btnNavSubcriptions.Font = new Font("Segoe UI", 9.75F);
            btnNavSubcriptions.ForeColor = Color.Silver;
            btnNavSubcriptions.Location = new Point(0, 195);
            btnNavSubcriptions.Name = "btnNavSubcriptions";
            btnNavSubcriptions.Padding = new Padding(10, 0, 0, 0);
            btnNavSubcriptions.Size = new Size(240, 55);
            btnNavSubcriptions.TabIndex = 3;
            btnNavSubcriptions.Text = "💳  Suscripciones";
            btnNavSubcriptions.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSubcriptions.UseVisualStyleBackColor = true;
            // 
            // btnNavPlans
            // 
            btnNavPlans.Cursor = Cursors.Hand;
            btnNavPlans.Dock = DockStyle.Top;
            btnNavPlans.FlatAppearance.BorderSize = 0;
            btnNavPlans.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 48, 56);
            btnNavPlans.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 48, 56);
            btnNavPlans.FlatStyle = FlatStyle.Flat;
            btnNavPlans.Font = new Font("Segoe UI", 9.75F);
            btnNavPlans.ForeColor = Color.Silver;
            btnNavPlans.Location = new Point(0, 140);
            btnNavPlans.Name = "btnNavPlans";
            btnNavPlans.Padding = new Padding(10, 0, 0, 0);
            btnNavPlans.Size = new Size(240, 55);
            btnNavPlans.TabIndex = 2;
            btnNavPlans.Text = "📋  Planes";
            btnNavPlans.TextAlign = ContentAlignment.MiddleLeft;
            btnNavPlans.UseVisualStyleBackColor = true;
            // 
            // btnNavMembers
            // 
            btnNavMembers.Cursor = Cursors.Hand;
            btnNavMembers.Dock = DockStyle.Top;
            btnNavMembers.FlatAppearance.BorderSize = 0;
            btnNavMembers.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 48, 56);
            btnNavMembers.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 48, 56);
            btnNavMembers.FlatStyle = FlatStyle.Flat;
            btnNavMembers.Font = new Font("Segoe UI", 9.75F);
            btnNavMembers.ForeColor = Color.Silver;
            btnNavMembers.Location = new Point(0, 85);
            btnNavMembers.Name = "btnNavMembers";
            btnNavMembers.Padding = new Padding(10, 0, 0, 0);
            btnNavMembers.Size = new Size(240, 55);
            btnNavMembers.TabIndex = 1;
            btnNavMembers.Text = "👥  Socios";
            btnNavMembers.TextAlign = ContentAlignment.MiddleLeft;
            btnNavMembers.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(picLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(240, 85);
            panelLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Padding = new Padding(16, 12, 16, 12);
            picLogo.Size = new Size(240, 85);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(241, 243, 239);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(240, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(894, 70);
            panelHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.FromArgb(32, 42, 34);
            lblHeader.Location = new Point(27, 31);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(195, 25);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Gestión de Gimnasio";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(246, 247, 244);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(240, 70);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(894, 541);
            panelContent.TabIndex = 2;
            // 
            // GymApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 611);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 550);
            Name = "GymApp";
            Text = "GymsharkADM";
            Load += GymApp_Load;
            panelSidebar.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelLogo;
        private Panel panelHeader;
        private Label lblHeader;
        private Button btnNavPayments;
        private Button btnNavAttendance;
        private Button btnNavSubcriptions;
        private Button btnNavPlans;
        private Button btnNavMembers;
        private Panel panelContent;
        private Button btnNavStats;
        private PictureBox picLogo;
    }
}
