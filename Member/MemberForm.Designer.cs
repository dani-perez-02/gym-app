namespace gym_app.Member
{
    partial class FrmMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelCard = new Panel();
            flowInputs = new FlowLayoutPanel();
            lblCardTitle = new Label();
            lblRut = new Label();
            txtRUT = new TextBox();
            lblNombre = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            panelRowButtons = new Panel();
            btnClear = new Button();
            btnSave = new Button();
            btnDisable = new Button();
            cbFiltro = new ComboBox();
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
            flowInputs.Controls.Add(lblRut);
            flowInputs.Controls.Add(txtRUT);
            flowInputs.Controls.Add(lblNombre);
            flowInputs.Controls.Add(txtName);
            flowInputs.Controls.Add(lblPhone);
            flowInputs.Controls.Add(txtPhone);
            flowInputs.Controls.Add(lblEmail);
            flowInputs.Controls.Add(txtEmail);
            flowInputs.Controls.Add(panelRowButtons);
            flowInputs.Controls.Add(btnDisable);
            flowInputs.Controls.Add(cbFiltro);
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
            lblCardTitle.Size = new Size(116, 20);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Datos del Socio";
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.ForeColor = Color.FromArgb(102, 112, 133);
            lblRut.Location = new Point(0, 36);
            lblRut.Margin = new Padding(0, 0, 0, 4);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(31, 15);
            lblRut.TabIndex = 1;
            lblRut.Text = "RUT:";
            // 
            // txtRUT
            // 
            txtRUT.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRUT.Location = new Point(0, 55);
            txtRUT.Margin = new Padding(0, 0, 0, 14);
            txtRUT.Name = "txtRUT";
            txtRUT.Size = new Size(270, 25);
            txtRUT.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.FromArgb(102, 112, 133);
            lblNombre.Location = new Point(0, 94);
            lblNombre.Margin = new Padding(0, 0, 0, 4);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(110, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre Completo:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(0, 113);
            txtName.Margin = new Padding(0, 0, 0, 14);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 25);
            txtName.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.ForeColor = Color.FromArgb(102, 112, 133);
            lblPhone.Location = new Point(0, 152);
            lblPhone.Margin = new Padding(0, 0, 0, 4);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(55, 15);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Teléfono:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(0, 171);
            txtPhone.Margin = new Padding(0, 0, 0, 14);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(270, 25);
            txtPhone.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.FromArgb(102, 112, 133);
            lblEmail.Location = new Point(0, 210);
            lblEmail.Margin = new Padding(0, 0, 0, 4);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(108, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Correo Electrónico:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(0, 229);
            txtEmail.Margin = new Padding(0, 0, 0, 14);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 25);
            txtEmail.TabIndex = 8;
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
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDisable
            // 
            btnDisable.BackColor = Color.FromArgb(183, 121, 121);
            btnDisable.Cursor = Cursors.Hand;
            btnDisable.FlatAppearance.BorderSize = 0;
            btnDisable.FlatStyle = FlatStyle.Flat;
            btnDisable.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisable.ForeColor = Color.White;
            btnDisable.Location = new Point(0, 320);
            btnDisable.Margin = new Padding(0, 4, 0, 0);
            btnDisable.Name = "btnDisable";
            btnDisable.Size = new Size(270, 34);
            btnDisable.TabIndex = 10;
            btnDisable.Text = "Desactivar Socio";
            btnDisable.UseVisualStyleBackColor = false;
            // 
            // cbFiltro
            // 
            cbFiltro.BackColor = Color.RoyalBlue;
            cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro.ForeColor = SystemColors.HighlightText;
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Location = new Point(3, 357);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(267, 23);
            cbFiltro.TabIndex = 11;
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
            // FrmMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(900, 580);
            Controls.Add(panelGridContainer);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMembers";
            Text = "Gestión de Socios";
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
        private Panel panelGridContainer;
        private Label lblRut;
        private TextBox txtRUT;
        private Label lblNombre;
        private TextBox txtName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Panel panelRowButtons;
        private Button btnSave;
        private Button btnClear;
        private Button btnDisable;
        private DataGridView dtView;
        private ComboBox cbFiltro;
    }
}