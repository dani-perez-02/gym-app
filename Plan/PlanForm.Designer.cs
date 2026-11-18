namespace gym_app.Plan
{
    partial class FrmPlans
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
            lblName = new Label();
            txtName = new TextBox();
            lblDuration = new Label();
            txtDuration = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            panelRowButtons = new Panel();
            btnClear = new Button();
            btnSave = new Button();
            btnDisable = new Button();
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
            flowInputs.Controls.Add(lblName);
            flowInputs.Controls.Add(txtName);
            flowInputs.Controls.Add(lblDuration);
            flowInputs.Controls.Add(txtDuration);
            flowInputs.Controls.Add(lblPrice);
            flowInputs.Controls.Add(txtPrice);
            flowInputs.Controls.Add(panelRowButtons);
            flowInputs.Controls.Add(btnDisable);
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
            lblCardTitle.Text = "Datos del Plan";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.FromArgb(102, 112, 133);
            lblName.Location = new Point(0, 36);
            lblName.Margin = new Padding(0, 0, 0, 4);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre del Plan:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(0, 55);
            txtName.Margin = new Padding(0, 0, 0, 14);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 25);
            txtName.TabIndex = 2;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.ForeColor = Color.FromArgb(102, 112, 133);
            lblDuration.Location = new Point(0, 94);
            lblDuration.Margin = new Padding(0, 0, 0, 4);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(92, 15);
            lblDuration.TabIndex = 3;
            lblDuration.Text = "Duración (días):";
            // 
            // txtDuration
            // 
            txtDuration.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDuration.Location = new Point(0, 113);
            txtDuration.Margin = new Padding(0, 0, 0, 14);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(270, 25);
            txtDuration.TabIndex = 4;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.ForeColor = Color.FromArgb(102, 112, 133);
            lblPrice.Location = new Point(0, 152);
            lblPrice.Margin = new Padding(0, 0, 0, 4);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(60, 15);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Precio ($):";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(0, 171);
            txtPrice.Margin = new Padding(0, 0, 0, 14);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(270, 25);
            txtPrice.TabIndex = 6;
            // 
            // panelRowButtons
            // 
            panelRowButtons.BackColor = Color.Transparent;
            panelRowButtons.Controls.Add(btnClear);
            panelRowButtons.Controls.Add(btnSave);
            panelRowButtons.Location = new Point(0, 210);
            panelRowButtons.Margin = new Padding(0, 0, 0, 10);
            panelRowButtons.Name = "panelRowButtons";
            panelRowButtons.Size = new Size(270, 38);
            panelRowButtons.TabIndex = 7;
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
            btnDisable.Location = new Point(0, 262);
            btnDisable.Margin = new Padding(0, 4, 0, 0);
            btnDisable.Name = "btnDisable";
            btnDisable.Size = new Size(270, 34);
            btnDisable.TabIndex = 8;
            btnDisable.Text = "Desactivar Plan";
            btnDisable.UseVisualStyleBackColor = false;
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
            // FrmPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(900, 580);
            Controls.Add(panelGridContainer);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPlans";
            Text = "Gestión de Planes";
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
        private Label lblName;
        private TextBox txtName;
        private Label lblDuration;
        private TextBox txtDuration;
        private Label lblPrice;
        private TextBox txtPrice;
        private Panel panelRowButtons;
        private Button btnClear;
        private Button btnSave;
        private Button btnDisable;
        private Panel panelGridContainer;
        private DataGridView dtView;
    }
}