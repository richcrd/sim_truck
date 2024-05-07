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
        public Viajes ViajeSeleccionado { get; set; }
        public Usuario usuario;

        public frmAsignarViaje(Viajes viajeSeleccionado)
        {
            InitializeComponent();
            lista_camiones = Gestion_Json.Cargar_Archivo<Camion>(@"../../arch_json/camiones.json");
            lista_choferes = Gestion_Json.Cargar_Archivo<Chofer>(@"../../arch_json/choferes.json");
            CargarCbx();
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            int choferSeleccionado = (int)cbxCamion.SelectedValue;
            int camionSeleccionado = (int)cbxChofer.SelectedValue;

            // Asignar el chofer y camion al viaje
            ViajeSeleccionado.ChoferId = choferSeleccionado;
            ViajeSeleccionado.CamionId = camionSeleccionado;
            ViajeSeleccionado.Estado = "En curso";

            // Devolver el resultado al formulario padre (frmJobs)
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CargarCbx()
        {
            // Filtra la lista de camiones
            List<Camion> camionesDisponibles = lista_camiones.Where(c => c.Estado == "Disponible").ToList();
            cbxCamion.DataSource = camionesDisponibles;
            cbxCamion.DisplayMember = "Modelo";
            cbxCamion.ValueMember = "Id";

            // Filtra la lista de choferes
            List<Chofer> choferesDisponibles = lista_choferes.Where(c => c.Estado == "Disponible").ToList();
            cbxChofer.DataSource = choferesDisponibles;
            cbxChofer.DisplayMember = "Nombre";
            cbxChofer.ValueMember = "Id";

        }
    }
}
