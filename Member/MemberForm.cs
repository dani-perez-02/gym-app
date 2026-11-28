using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gym_app.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gym_app.Member
{
    internal partial class FrmMembers : Form, IMemberView
    {
        public FrmMembers()
        {
            InitializeComponent();
            ConfigureFilter();
            ConfigureEvents();
            ConfigureGrid();

            btnSave.Text = "Guardar";
            btnDisable.Enabled = false;
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
        public MemberFilter.MembersFilter SelectFilter
        {
            get
            {
                if (cbFiltro.SelectedItem is MemberFilter.MembersFilter filter)
                {
                    return filter;
                }
                else
                {
                    return MemberFilter.MembersFilter.Todos;
                }
            }
        }

        public event EventHandler SaveEvent;
        public event EventHandler DisableEvent;
        public event EventHandler ClearEvent;
        public event EventHandler<Member> MemberSelectedEvent;
        
        private void ConfigureFilter()
        {
            cbFiltro.DataSource = Enum.GetValues<MemberFilter.MembersFilter>();
            cbFiltro.SelectedIndex = 0;

        }
        

        private void ConfigureEvents()
        {
            btnSave.Click += (s, e) => SaveEvent?.Invoke(this, EventArgs.Empty);
            btnDisable.Click += (s, e) => DisableEvent?.Invoke(this, EventArgs.Empty);
            btnClear.Click += (s, e) => ClearEvent?.Invoke(this, EventArgs.Empty);
            dtView.CellClick += dtView_CellClick;
            dtView.CellFormatting += dtView_CellFormatting;
            cbFiltro.SelectedIndexChanged += (s,e) => FilterChangeEvent?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler? FilterChangeEvent;

        public void ClearInputs()
        {
            MemberId = 0;
            txtRUT.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();

            txtRUT.Focus();
            btnSave.Text = "Guardar";
            btnDisable.Enabled = false;
        }

        public void DisplayMembers(IEnumerable<Member> members)
        {
            dtView.DataSource = members.ToList(); 
        }

        public void ShowMember(Member member)
        {
            btnSave.Text = "Actualizar";
            btnDisable.Enabled = true;

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

        private void dtView_CellFormatting(object? sender , DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (dtView.Columns[e.ColumnIndex].DataPropertyName == nameof(Member.IsActive))
            {
                if (e.Value is bool isActive)
                {
                    e.Value = isActive ? "Activo" : "Inactivo";
                    e.FormattingApplied = true;
                }
            }
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
                FillWeight = 17
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Member.Name),
                HeaderText = "Nombre",
                FillWeight = 24
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Member.Phone),
                HeaderText = "Teléfono",
                FillWeight = 15
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Member.IsActive),
                HeaderText = "Estado",
                FillWeight = 16
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Member.Email),
                HeaderText = "Correo",
                FillWeight = 18
            });

            dtView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Member.RegisteredAt),
                HeaderText = "Registro",
                FillWeight = 10,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            GridStyler.Apply(dtView);
        }

    }
}
