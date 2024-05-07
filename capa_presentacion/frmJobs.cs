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
using SIM_TRUCK.capa_negocio;

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
        public Label lblCuentaRegresiva;
        public Panel pnlCuentaRegresiva;
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
            if (dgvTrabajos.SelectedRows.Count > 0)
            {
                Viajes viajeSeleccionado = (Viajes)dgvTrabajos.SelectedRows[0].DataBoundItem;
                frmAsignarViaje fav = new frmAsignarViaje(viajeSeleccionado);
                var resultado = fav.ShowDialog();

                if(resultado == DialogResult.OK)
                {
                    CrearPanelCuentaRegresiva();
                    // Asigna el viaje seleccionado del formulario hijo al formulario padre
                    this.viajeSeleccionado = fav.ViajeSeleccionado;
                    CuentaRegresiva.Start();
                }
            }
            else
            {
                Controles.MostrarMensaje("Por favor selecciona un trabajo disponible.", "Error", MessageBoxIcon.Error);
            }

        }

        private void CuentaRegresiva_Tick(object sender, EventArgs e)
        {
            // Verificar si el viaje seleccionado no es nulo y tiene una duración válida
            if (viajeSeleccionado != null && viajeSeleccionado.Duracion > TimeSpan.Zero)
            {
                // Actualizar el tiempo restante
                viajeSeleccionado.Duracion = viajeSeleccionado.Duracion.Subtract(TimeSpan.FromSeconds(1));
                lblCuentaRegresiva.Text = viajeSeleccionado.Duracion.ToString(@"hh\:mm\:ss");

                // Si la cuenta regresiva llega a cero
                if (viajeSeleccionado.Duracion == TimeSpan.Zero)
                {
                    // Finaliza el viaje
                    viajeSeleccionado.Estado = "Disponible";

                    // Actualiza el balance del usuario
                    usuario.BalanceDinero += viajeSeleccionado.Pago;

                    // Muestra un mensaje al usuario
                    MessageBox.Show("El viaje ha finalizado. El pago se ha realizado.");

                    // Actualiza la lista de trabajos
                    ListaTrabajos();
                    ActualizarBalanceDinero();

                    // Actualizamos la lista de camiones del usuario logeado en la lista del usuario
                    foreach (var user in lista_usuarios)
                    {
                        if (user.Id == usuario.Id)
                        {
                            user.BalanceDinero = usuario.BalanceDinero;
                            break;
                        }
                    }

                    Gestion_Json.Guardar_Archivo(lista_usuarios, @"../../arch_json/usuarios.json");
                }
            }
            else
            {
                // Detener la cuenta regresiva si el viaje ha sido completado o no hay viaje seleccionado
                CuentaRegresiva.Stop();

                // Eliminar el panel de cuenta regresiva
                pnlCuentaRegresiva.Controls.Clear();
            }
        }

        private void CrearPanelCuentaRegresiva()
        {
            pnlCuentaRegresiva.Size = new Size(200, 50);
            pnlCuentaRegresiva.BackColor = Color.LightGray;

            lblCuentaRegresiva.Text = "00:00:00";
            lblCuentaRegresiva.Size = new Size(50,50);
            lblCuentaRegresiva.TextAlign = ContentAlignment.MiddleCenter;

            pnlCuentaRegresiva.Controls.Add(lblCuentaRegresiva);
            panelContenedor3.Controls.Add(pnlCuentaRegresiva);
        }
    }
}
