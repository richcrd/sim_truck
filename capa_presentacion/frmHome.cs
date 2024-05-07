using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIM_TRUCK.capa_datos;
using SIM_TRUCK.capa_entidades;
using SIM_TRUCK.capa_presentacion;

namespace SIM_TRUCK
{
    public partial class frmHome : Form
    {
        #region variables && propiedades

        private static List<Usuario> lista_usuarios;

        private static ToolStripMenuItem active_menu = null;

        private static Form active_form = null;
        public string LblUsuario { get; set; }
        public int LblDinero { get; set; }

        public Usuario usuario;
        #endregion

        #region inicializacion
        public frmHome()
        {
            InitializeComponent();
            lista_usuarios = Gestion_Json.Cargar_Archivo<Usuario>(@"../../arch_json/usuarios.json");
            MostrarNombreUsuario();
            ActualizarDinero();
        }
        #endregion

        #region Mostrar Datos

        public void ActualizarDinero()
        {
            if (UsuarioActual.UsuarioLogeado != null)
            {
                lblMoney.Text = UsuarioActual.UsuarioLogeado.BalanceDinero.ToString();
            }
        }

        private void MostrarNombreUsuario()
        {
            if (UsuarioActual.UsuarioLogeado != null)
            {
                lblUser.Text = UsuarioActual.UsuarioLogeado.Nombre;
            }
        }
        #endregion

        #region ShowForms Methods
        private void Show_Form(ToolStripMenuItem menu, Form form)
        {
            if (active_menu != null)
            {
                active_menu.BackColor = Color.White;
            }
            menu.BackColor = Color.LightBlue;
            active_menu = menu;

            if (active_form != null)
            {
                active_form.Close();
            }
            active_form = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.WhiteSmoke;

            pnlContainer.Controls.Add(form);
            form.Show();

        }

        private void menuOffice_Click(object sender, EventArgs e)
        {
            Show_Form(menuOffice, new frmOffice(UsuarioActual.UsuarioLogeado));
        }

        private void menuJobs_Click(object sender, EventArgs e)
        {
            Show_Form(menuJobs, new frmJobs(UsuarioActual.UsuarioLogeado));
        }

        private void submenuTravelStat_Click(object sender, EventArgs e)
        {
            Show_Form(submenuTravelStat, new frmTravel(UsuarioActual.UsuarioLogeado));
        }

        private void submenuDriverStat_Click(object sender, EventArgs e)
        {
            Show_Form(submenuDriverStat, new frmDriver(UsuarioActual.UsuarioLogeado));
        }
        private void sbmComprarC_Click(object sender, EventArgs e)
        {
            Show_Form(sbmComprarC, new frmComprarCamion(UsuarioActual.UsuarioLogeado));
        }
        private void sbmVenderC_Click(object sender, EventArgs e)
        {
            Show_Form(sbmVenderC, new frmVenderCamion(UsuarioActual.UsuarioLogeado));
        }
        #endregion

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            UsuarioActual.UsuarioLogeado = null;
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
