using SIM_TRUCK.capa_entidades;
using SIM_TRUCK.capa_datos;
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
    public partial class frmJobs : Form
    {
        #region Propiedades
        private static List<Camion> lista_camiones;
        private static List<Usuario> lista_usuarios;
        private static List<Viajes> lista_viajes;
        public Usuario usuario;
        public Viajes viajeSeleccionado;
        #endregion
        public frmJobs(Usuario usuarioLogeado)
        {
            InitializeComponent();

            lista_camiones = Gestion_Json.Cargar_Archivo<Camion>(@"../../arch_json/camiones.json");
            lista_usuarios = Gestion_Json.Cargar_Archivo<Usuario>(@"../../arch_json/usuarios.json");
            lista_viajes = Gestion_Json.Cargar_Archivo<Viajes>(@"../../arch_json/viajes.json");
            usuario = usuarioLogeado;
            ListaTrabajos();
            ListarTrabajosUsuario();
        }

        #region Metodos Procedimientos
        private void ListarTrabajosUsuario()
        {
            dgvTrabajos.DataSource = null; // limpia los datos actuales
            dgvTrabajos.DataSource = ObtenerListaTrabajos();

            dgvTrabajos.Columns["Id"].HeaderText = "ID";
            dgvTrabajos.Columns["CamionId"].HeaderText = "CamionId";
            dgvTrabajos.Columns["ChoferId"].HeaderText = "ChoferId";
            dgvTrabajos.Columns["Inicia"].HeaderText = "Inicia";
            dgvTrabajos.Columns["Termina"].HeaderText = "Termina";
            dgvTrabajos.Columns["Duracion"].HeaderText = "Duracion";
            dgvTrabajos.Columns["Pago"].HeaderText = "Pago";
        }

        private void ListaTrabajos()
        {
            dgvTrabajos.DataSource = null; // limpia los datos actuales
            dgvTrabajos.DataSource = lista_viajes;

            dgvTrabajos.Columns["Id"].HeaderText = "ID";
            dgvTrabajos.Columns["CamionId"].HeaderText = "CamionId";
            dgvTrabajos.Columns["ChoferId"].HeaderText = "ChoferId";
            dgvTrabajos.Columns["Inicia"].HeaderText = "Inicia";
            dgvTrabajos.Columns["Termina"].HeaderText = "Termina";
            dgvTrabajos.Columns["Duracion"].HeaderText = "Duracion";
            dgvTrabajos.Columns["Pago"].HeaderText = "Pago";
        }

        private List<Viajes> ObtenerListaTrabajos()
        {
            // Filtra los camiones segun los IDS en la lista del usuario
            return lista_viajes.Where(v => usuario.Viajes.Contains(v.Id)).ToList();
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
        #endregion

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Viajes viajeSeleccionado = (Viajes)dgvTrabajos.SelectedRows[0].DataBoundItem;
            frmAsignarViaje frmAsignarViaje = new frmAsignarViaje(viajeSeleccionado);
            frmAsignarViaje.ShowDialog();

            ListaTrabajos();

        }

        private void CuentaRegresiva_Tick(object sender, EventArgs e)
        {
            // Actualiza el tiempo restante
            lblTimer.Text = viajeSeleccionado.Duracion.ToString(@"mm:ss");

            // Si la cuenta regresiva llega a cero
            if (viajeSeleccionado.Duracion == "00:00:00")
            {
                // Finaliza el viaje
                viajeSeleccionado.Estado = "Finalizado";

                // Calcula el pago
                viajeSeleccionado.Pago = CalcularPago(viajeSeleccionado);

                // Actualiza el balance del usuario
                usuario.Balance += viajeSeleccionado.Pago;

                // Muestra un mensaje al usuario
                MessageBox.Show("El viaje ha finalizado. El pago se ha realizado.");

                // Actualiza la lista de trabajos
                ListaTrabajos();

                // Cierra el formulario
                this.Close();
            }

            // Disminuye la duración del viaje
            viajeSeleccionado.Duracion--;
        }

        private object CalcularPago(object viajeSeleccionado)
        {
            throw new NotImplementedException();
        }
    }
}
