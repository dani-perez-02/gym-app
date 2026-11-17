


using System.Drawing;

namespace gym_app
{
    // aca se gestiona la ventana principal, en la cual se mostrara la seccion indicada,
    // dependiendo del boton seleccionado en la navegacion lateral.
    public partial class GymApp : Form
    {
        // estados
        private Form _activeForm; // la ventana abierta actualmente
        private Button _activeButton; // el boton seleccionado en la navegacion

        // constantes para el color de los botones segun estado
        private readonly Color ColorSidebarActive = Color.FromArgb(12, 31, 21);
        private readonly Color ColorSidebarNormal = Color.FromArgb(12, 31, 61);
        private readonly Color ColorTxtActive = Color.White;
        private readonly Color ColorTxtNormal = Color.Silver;

        public GymApp()
        {
            InitializeComponent();

            // Enlazar botones con sus eventos
            ConfigureInitialEvents();
            // Abrir el panel por defecto
            OpenMembersPanel(btnNavMembers);
        }

        private void ConfigureInitialEvents()
        {
            btnNavMembers.Click += (s, e) => OpenMembersPanel(btnNavMembers);
            btnNavPlans.Click += (s, e) => OpenPlansPanel(btnNavPlans);
            btnNavSubcriptions.Click += (s, e) => OpenSubscriptionsPanel(btnNavSubcriptions);
            btnNavAttendance.Click += (s, e) => OpenAttendancePanel(btnNavAttendance);
        }


        private void HighlightActiveButton(Button btn)
        {
            if (_activeButton != null) // si existe un boton que esta "activo" actualmente, borramos su estilo para marcar otro como activo
            {
                _activeButton.BackColor = ColorSidebarNormal;
                _activeButton.ForeColor = ColorTxtNormal;
                _activeButton.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            }
            // Si no hay un boton ya seleccionado, marcamos el boton recibido como el activo
            _activeButton = btn;
            _activeButton.BackColor = ColorSidebarActive;
            _activeButton.ForeColor= ColorTxtActive;
            _activeButton.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
        }

        // Como vamos a cargar una ventana "dentro" del panel 
        private void LoadFormInPanel(Form childForm, string moduleTitle)
        {
            if (_activeForm != null) // si ya hay una ventana abierta, la cerramos.
            {
                _activeForm.Close();
            }
            _activeForm = childForm; 
            lblHeader.Text = moduleTitle;
            _activeForm.TopLevel = false;
            _activeForm.FormBorderStyle = FormBorderStyle.None; 
            panelContent.Controls.Add(_activeForm);
        }

        private void OpenMembersPanel(Button btnNavMembers)
        {
            HighlightActiveButton(btnNavMembers);

            var view = new Form(); // cambiar esto cuando tengamos la wea
            LoadFormInPanel(view, "Gestión de Socios");

        }

        private void OpenSubscriptionsPanel(Button btnNavSubcriptions)
        {
            HighlightActiveButton(btnNavSubcriptions);

            var view = new Form(); 
            LoadFormInPanel(view, "Gestión de Suscripciones");
        }

        private void OpenPlansPanel(Button btnNavPlans)
        {
            HighlightActiveButton(btnNavPlans);

            var view = new Form();
            LoadFormInPanel(view, "Gestión de Planes");
        }
        private void OpenAttendancePanel(Button btnNavAttendance)
        {
            HighlightActiveButton(btnNavAttendance);
            
            var view = new Form();
            LoadFormInPanel(view, "Gestión de Asistencia")
        }
    }
}
