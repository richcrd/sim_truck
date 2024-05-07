using SIM_TRUCK.capa_datos;
using SIM_TRUCK.capa_entidades;
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
    public partial class frmAsignarViaje : Form
    {
        private static List<Camion> lista_camiones;
        private static List<Chofer> lista_choferes;
        private Viajes viajeSeleccionado;
        public Usuario usuario;
        public frmAsignarViaje(Viajes viajeSeleccionado)
        {
            InitializeComponent();
            lista_camiones = Gestion_Json.Cargar_Archivo<Camion>(@"../../arch_json/camiones.json");
            lista_choferes = Gestion_Json.Cargar_Archivo<Chofer>(@"../../arch_json/choferes.json");

            //lblIdViaje.Text = viajeSeleccionado.Id.ToString();
            //lblFechaInicio.Text = viajeSeleccionado.Inicia.ToString("hh:mm:ss");
            //lblFechaFin.Text = viajeSeleccionado.Termina.ToString("hh:mm:ss");
            //lblDuracion.Text = viajeSeleccionado.Duracion.ToString();
            //lblPago.Text = viajeSeleccionado.Pago.ToString();

            // Filtra la lista de choferes
            List<Chofer> choferesDisponibles = lista_choferes.Where(c => c.Estado == "Disponible").ToList();
            cbxChofer.DataSource = choferesDisponibles;
            cbxChofer.DisplayMember = "Nombre";
            cbxChofer.ValueMember = "Id";

            // Filtra la lista de camiones
            List<Camion> camionesDisponibles = lista_camiones.Where(c => c.Estado == "Disponible").ToList();
            cbxCamion.DataSource = camionesDisponibles;
            cbxCamion.DisplayMember = "Modelo";
            cbxCamion.ValueMember = "Id";
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            int choferID = (int)cbxCamion.SelectedValue;
            int camionID = (int)cbxChofer.SelectedValue;

            // Inicia el viaje
            viajeSeleccionado.ChoferId = choferID;
            viajeSeleccionado.CamionId = camionID;
            viajeSeleccionado.Estado = "En curso";

            // Inicia la cuenta regresiva
            cuentaRegresiva.Start();

            // Deshabilita los combobox
            cbxChofer.Enabled = false;
            cbxCamion.Enabled = false;
        }
    }
}
