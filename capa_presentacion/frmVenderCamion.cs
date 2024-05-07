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
using SIM_TRUCK.capa_negocio;

namespace SIM_TRUCK.capa_presentacion
{
    public partial class frmVenderCamion : Form
    {
        #region Propiedades
        private static List<Camion> lista_camiones;
        private static List<Usuario> lista_usuarios;
        public Usuario usuario;
        #endregion

        #region Inicializacion
        public frmVenderCamion(Usuario usuarioLogeado)
        {
            InitializeComponent();

            lista_camiones = Gestion_Json.Cargar_Archivo<Camion>(@"../../arch_json/camiones.json");
            lista_usuarios = Gestion_Json.Cargar_Archivo<Usuario>(@"../../arch_json/usuarios.json");
            usuario = usuarioLogeado;
            ActualizarTabla();
        }
        #endregion

        #region Metodos Procedimientos
        private void ActualizarTabla()
        {
            dgv_MisCamiones.DataSource = null; // limpia los datos actuales
            dgv_MisCamiones.DataSource = Obtener_Camiones_Usuario();

            dgv_MisCamiones.Columns["Id"].HeaderText = "ID";
            dgv_MisCamiones.Columns["Modelo"].HeaderText = "Modelo";
            dgv_MisCamiones.Columns["Capacidad"].HeaderText = "Capacidad";
            dgv_MisCamiones.Columns["Estado"].HeaderText = "Estado";
            dgv_MisCamiones.Columns["Precio"].HeaderText = "Precio";
        }
        #endregion

        private void btnVender_Click(object sender, EventArgs e)
        {
            RealizarVenta();
            ActualizarTabla();
        }

        private List<Camion> Obtener_Camiones_Usuario()
        {
            // Filtra los camiones segun los IDS en la lista del usuario
            return lista_camiones.Where(c => usuario.Camiones.Contains(c.Id)).ToList();
        }

        private void RealizarVenta()
        {
            Camion camionSeleccionado = dgv_MisCamiones.SelectedRows[0].DataBoundItem as Camion;
            usuario.BalanceDinero += camionSeleccionado.Precio;

            ActualizarBalanceDinero();

            Controles.MostrarMensaje($"Venta exitosa! El camion ha sido vendido", "Venta Exitosa", MessageBoxIcon.Information);

            // Removemos el ID del camion vendido de la lista del usuario
            usuario.Camiones.Remove(camionSeleccionado.Id);
            

            // Actualizamos la lista de camiones del usuario logeado en la lista del usuario
            foreach(var user in lista_usuarios)
            {
                if(user.Id == usuario.Id)
                {
                    user.Camiones = usuario.Camiones;
                    user.BalanceDinero = usuario.BalanceDinero;
                    break;
                }
            }

            Gestion_Json.Guardar_Archivo(lista_usuarios, @"../../arch_json/usuarios.json");
        }

        private void ActualizarBalanceDinero()
        {
            // Actualizamos el dinero en el formulario frmHome
            frmHome homeForm = Application.OpenForms.OfType<frmHome>().FirstOrDefault();
            if (homeForm != null)
            {
                homeForm.ActualizarDinero();
            }
        }
    }
}
