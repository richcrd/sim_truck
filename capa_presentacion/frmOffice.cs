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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SIM_TRUCK.capa_presentacion
{
    public partial class frmOffice : Form
    {
        #region Propiedades
        private static List<Usuario> lista_usuarios;
        private static List<Camion> lista_camiones;
        private static List<Chofer> lista_choferes;
        public Usuario usuario;
        #endregion

        #region Inicializacion
        public frmOffice(Usuario usuarioLogeado)
        {
            InitializeComponent();
            lista_usuarios = Gestion_Json.Cargar_Archivo<Usuario>(@"../../arch_json/usuarios.json");
            lista_camiones = Gestion_Json.Cargar_Archivo<Camion>(@"../../arch_json/camiones.json");
            lista_choferes = Gestion_Json.Cargar_Archivo<Chofer>(@"../../arch_json/choferes.json");
            usuario = usuarioLogeado;
            ActualizarTablaBusqueda();
            ActualizarTablaEmpleados();
            VerCantidadCamionesYEmpleados();
        }
        #endregion

        #region EventosClick
        private void btnContratar_Click(object sender, EventArgs e)
        {
            ContratarChofer();
            ActualizarTablaBusqueda();
            ActualizarTablaEmpleados();
            VerCantidadCamionesYEmpleados();
        }

        private void btnDespedir_Click(object sender, EventArgs e)
        {
            DespedirChofer();
            ActualizarTablaEmpleados();
            VerCantidadCamionesYEmpleados();
        }
        #endregion

        #region Metodos Contratacion
        private void ContratarChofer()
        {
            switch (VerificarSeleccion())
            {
                case 1:
                    RealizarContratacion();
                    break;
                case 2:
                    Controles.MostrarMensaje("No tienes suficiente dinero para realizar la compra", "Error", MessageBoxIcon.Error);
                    break;
                case 3:
                    Controles.MostrarMensaje("El chofer seleccionado no es válido", "Error", MessageBoxIcon.Error);
                    break;
                default:
                    Controles.MostrarMensaje("No has seleccionado ningun chofer", "Error", MessageBoxIcon.Error);
                    break;
            }
        }
        private int VerificarSeleccion()
        {
            if (dgvChoferes.SelectedRows.Count > 0)
            {
                Chofer choferSeleccionado = dgvChoferes.SelectedRows[0].DataBoundItem as Chofer;
                if (choferSeleccionado != null)
                {
                    if (usuario.BalanceDinero >= choferSeleccionado.Salario)
                    {
                        return 1; // Contrato Exitoso
                    }
                    else
                    {
                        return 2; // No hay dinero
                    }
                }
                else
                {
                    return 3; // chofer no valido
                }
            }
            else
            {
                return 4; // No se ha seleccionado ningun chofer
            }
        }
        private void RealizarContratacion()
        {
            Chofer choferSeleccionado = dgvChoferes.SelectedRows[0].DataBoundItem as Chofer;
            usuario.BalanceDinero -= choferSeleccionado.Salario;
            ActualizarBalanceDinero();

            Controles.MostrarMensaje($"Exito! El chofer acepta el contrato, se dirige a tu oficina", "Contrato", MessageBoxIcon.Information);
            // Agregamos el ID del camión comprado a la lista del usuario
            usuario.Choferes.Add(choferSeleccionado.Id);

            // Actualizamos la lista de camiones del usuario logeado en la lista de usuarios
            foreach (var user in lista_usuarios)
            {
                if (user.Id == usuario.Id)
                {
                    user.Choferes = usuario.Choferes;
                    user.BalanceDinero = usuario.BalanceDinero;
                    break;
                }
            }
            //usuario.Camiones = usuario.Camiones.Concat(new[] { camionSeleccionado.Id }).ToList();
            // Guardamos la lista actualizada de usuario en el json
            Gestion_Json.Guardar_Archivo(lista_usuarios, @"../../arch_json/usuarios.json");
        }

        #endregion

        #region Tabla
        private void ActualizarBalanceDinero()
        {
            // Actualizamos el dinero en el formulario frmHome
            frmHome homeForm = Application.OpenForms.OfType<frmHome>().FirstOrDefault();
            if (homeForm != null)
            {
                homeForm.ActualizarDinero();
            }
        }
        private void ActualizarTablaEmpleados()
        {
            dgvMisEmpleados.DataSource = null; // limpia los datos actuales
            dgvMisEmpleados.DataSource = ObtenerMisEmpleados();

            dgvChoferes.Columns["Id"].HeaderText = "ID";
            dgvChoferes.Columns["Nombre"].HeaderText = "Nombre";
            dgvChoferes.Columns["Experiencia"].HeaderText = "Experiencia";
            dgvChoferes.Columns["Estado"].HeaderText = "Estado";
            dgvChoferes.Columns["Salario"].HeaderText = "Salario";
        }
        private List<Chofer> ObtenerMisEmpleados()
        {
            // Filtra los camiones segun los IDS en la lista del usuario
            return lista_choferes.Where(cf => usuario.Choferes.Contains(cf.Id)).ToList();
        }
        private void ActualizarTablaBusqueda()
        {
            dgvChoferes.DataSource = null;
            dgvChoferes.DataSource = lista_choferes;

            dgvChoferes.Columns["Id"].HeaderText = "ID";
            dgvChoferes.Columns["Nombre"].HeaderText = "Nombre";
            dgvChoferes.Columns["Experiencia"].HeaderText = "Experiencia";
            dgvChoferes.Columns["Estado"].HeaderText = "Estado";
            dgvChoferes.Columns["Salario"].HeaderText = "Salario";
        }
        #endregion

        #region lbl
        private void VerCantidadCamionesYEmpleados()
        {
            int cantidadCamiones = usuario.Camiones.Count;
            int cantidadEmpleados = usuario.Choferes.Count;

            lblCamiones.Text = cantidadCamiones.ToString();
            lblEmpleados.Text = cantidadEmpleados.ToString();
        }
        #endregion

        #region Metodos Despedida
        private void DespedirChofer()
        {
            Chofer choferSeleccionado = dgvChoferes.SelectedRows[0].DataBoundItem as Chofer;

            Controles.MostrarMensaje($"El chofer se despide de tu oficina", "Contrato", MessageBoxIcon.Information);

            usuario.Choferes.Remove(choferSeleccionado.Id);

            // Actualizamos la lista de camiones del usuario logeado en la lista de usuarios
            foreach (var user in lista_usuarios)
            {
                if (user.Id == usuario.Id)
                {
                    user.Choferes = usuario.Choferes;
                    break;
                }
            }
            Gestion_Json.Guardar_Archivo(lista_usuarios, @"../../arch_json/usuarios.json");
        }
        #endregion
    }
}