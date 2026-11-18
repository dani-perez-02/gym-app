using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gym_app.Member
{
    internal partial class FrmMembers : Form, IMemberView
    {
        public FrmMembers()
        {
            InitializeComponent();
            ConfigureEvents();
            ConfigureGrid();
        }

        public int MemberId { get; set; }
        public string MemberName
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }
        public string MemberRut
        {
            get => txtRUT.Text;
            set => txtRUT.Text = value;
        }
        public string MemberPhone
        {
            get => txtPhone.Text;
            set => txtPhone.Text = value;
        }
        public string MemberEmail
        {
            get => txtEmail.Text;
            set => txtEmail.Text = value;
        }

        public event EventHandler SaveEvent;
        public event EventHandler DisableEvent;
        public event EventHandler ClearEvent;
        public event EventHandler<Member> MemberSelectedEvent;


        private void ConfigureEvents()
        {
            btnSave.Click += (s, e) => SaveEvent?.Invoke(this, EventArgs.Empty);
            btnDisable.Click += (s, e) => DisableEvent?.Invoke(this, EventArgs.Empty);
            btnClear.Click += (s, e) => ClearEvent?.Invoke(this, EventArgs.Empty);
            dtView.CellClick += dtView_CellClick;
        }

        public void ClearInputs()
        {
            MemberId = 0;
            txtRUT.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();

            txtRUT.Focus();
        }

        public void DisplayMembers(IEnumerable<Member> members)
        {
            dtView.DataSource = members.ToList(); 
        }

        public void ShowMember(Member member)
        {
            MemberId = member.MemberId;
            MemberRut = member.Rut;
            MemberName = member.Name;
            MemberPhone = member.Phone;
            MemberEmail = member.Email;
        }

        public void ShowMessage(string msg, bool isError = false)
        {
            MessageBox.Show(
                msg,
                isError ? "Atencion" : "Informacion",
                MessageBoxButtons.OK,
                isError ? MessageBoxIcon.Warning : MessageBoxIcon.Information
                );
        }

        private void dtView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // si hace click en el header, no hacer nada.
            var row = dtView.Rows[e.RowIndex]; // la fila clickeada
            var member = (Member)row.DataBoundItem; // el objeto que hay detras

            MemberSelectedEvent?.Invoke(this, member);
        }

        private void ConfigureGrid()
        {
            dtView.AutoGenerateColumns = false;
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtView.Columns.Clear();

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Member.MemberId),
                HeaderText = "ID",
                Visible = false
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Member.Rut),
                HeaderText = "RUT",
                FillWeight = 20
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Member.Name),
                HeaderText = "Nombre",
                FillWeight = 30
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Member.Phone),
                HeaderText = "Teléfono",
                FillWeight = 18
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Member.Email),
                HeaderText = "Correo",
                FillWeight = 20
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Member.RegisteredAt),
                HeaderText = "Registro",
                FillWeight = 12,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });
        }

    }
}
