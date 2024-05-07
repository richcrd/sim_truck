using SIM_TRUCK.capa_datos;
using SIM_TRUCK.capa_entidades;
using SIM_TRUCK.capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TRUCK.capa_presentacion
{
    public partial class frmLogin : Form
    {
        private static List<Usuario> lista_usuarios;
        public frmLogin()
        {
            InitializeComponent();
             lista_usuarios = Gestion_Json.Cargar_Archivo<Usuario>(@"../../arch_json/usuarios.json");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtName.Text;
            string contrasena = txtPass.Text;

            Usuario usuarioLogeado = IniciarSesion(nombreUsuario, contrasena);

            if (Controles.TextBoxEstaVacio(txtName, txtPass))
            {
                Controles.MostrarMensaje("Debes completar todos los campos ", "Error", MessageBoxIcon.Error);
                Controles.LimpiarTxt(txtName, txtPass);
            }
            else
            {
                if (usuarioLogeado != null)
                {
                    UsuarioActual.UsuarioLogeado = usuarioLogeado;
                    Controles.LimpiarTxt(txtName, txtPass);
                    Controles.MostrarMensaje("Bienvenido, " + usuarioLogeado.Nombre, "Bienvenida", MessageBoxIcon.Information);
                    frmHome h = new frmHome();
                    h.Show();
                    this.Hide();
                }
                else
                {
                    Controles.MostrarMensaje("Usuario o contrasena incorrectos, intenta de nuevo!!", "Error", MessageBoxIcon.Information);
                }
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmNuevaCuenta ca = new frmNuevaCuenta();
            ca.Show();
            this.Hide();
        }

        private Usuario IniciarSesion(string nombreUsuario,string contrasena)
        {
           return lista_usuarios.FirstOrDefault(u => u.Nombre == nombreUsuario && u.Contrasena == contrasena);
        }
    }
    public static class UsuarioActual
    {
        public static Usuario UsuarioLogeado { get; set; }
    }
}
