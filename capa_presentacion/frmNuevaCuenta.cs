using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIM_TRUCK.capa_entidades;
using SIM_TRUCK.capa_datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;
using SIM_TRUCK.capa_negocio;

namespace SIM_TRUCK.capa_presentacion
{
    public partial class frmNuevaCuenta : Form
    {
        private static List<Usuario> lista_usuarios;
        public frmNuevaCuenta()
        {
            InitializeComponent();
            lista_usuarios = Gestion_Json.Cargar_Archivo<Usuario>(@"../../arch_json/usuarios.json");
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtName.Text;
            string contrasena = txtPass.Text;

            if (UsuarioExiste(nombreUsuario, contrasena))
            {
                Controles.MostrarMensaje("Usuario ya existe, por favor ingrese uno diferente (Puedes usar numeros)", "Error", MessageBoxIcon.Error);
            }
            else
            {
                int nuevoId = Generar_ID();
                Usuario nuevoUsuario = new Usuario(
                    nuevoId,
                    txtName.Text,
                    txtPass.Text,
                    25000,
                    new List<int>(),
                    new List<int>(),
                    new List<int>()
                );

                lista_usuarios.Add(nuevoUsuario);
                Gestion_Json.Guardar_Archivo(lista_usuarios, @"../../arch_json/usuarios.json");
                UsuarioActual.UsuarioLogeado = nuevoUsuario;
                MostrarFormulario(new frmHome());
            }
        }

        private bool UsuarioExiste(string nombreUsuario, string contrasena)
        {
            return lista_usuarios.Any(u => u.Nombre == nombreUsuario && u.Contrasena == contrasena);
        }

        public void MostrarFormulario(Form formulario)
        {
            formulario.Show();
            this.Hide();
        }

        #region ID
        public static int Generar_ID()
        {
            int ultimoID = Obtener_Ultimo_ID();
            int nuevoID = ultimoID + 1;
            return nuevoID;
        }

        public static int Obtener_Ultimo_ID()
        {
            int maxID = 0;
            foreach (var usuario in lista_usuarios)
            {
                int usuarioID = usuario.Id;
                if (usuarioID > maxID)
                {
                    maxID = usuarioID;
                }
            }
            return maxID;
        }
        #endregion
    }
}
