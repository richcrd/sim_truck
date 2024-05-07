using SIM_TRUCK.capa_datos;
using SIM_TRUCK.capa_entidades;
using SIM_TRUCK.capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TRUCK.capa_presentacion
{
    public partial class frmComprarCamion : Form
    {
        #region Propiedades y Lista
        private static List<Camion> lista_camiones;
        private static List<Usuario> lista_usuarios;
        public Usuario usuario;
        #endregion

        #region Inicializacion
        public frmComprarCamion(Usuario usuarioLogeado)
        {
            InitializeComponent();

            lista_camiones = Gestion_Json.Cargar_Archivo<Camion>(@"../../arch_json/camiones.json");
            lista_usuarios = Gestion_Json.Cargar_Archivo<Usuario>(@"../../arch_json/usuarios.json");
            usuario = usuarioLogeado;
            ActualizarTablaCamion();
        }
        #endregion

        #region Metodos Procedimientos
        public void ComprarCamion()
        {
            switch (VerificarSeleccion())
            {
                case 1:
                    RealizarCompra();
                    break;
                case 2:
                    Controles.MostrarMensaje("No tienes suficiente dinero para realizar la compra", "Error", MessageBoxIcon.Error);
                    break;
                case 3:
                    Controles.MostrarMensaje("El camión seleccionado no es válido", "Error", MessageBoxIcon.Error);
                    break;
                default:
                    Controles.MostrarMensaje("No has seleccionado ningún camión", "Error", MessageBoxIcon.Error);
                    break;
            }
        }

        private int VerificarSeleccion()
        {
            if(dgv_Camiones.SelectedRows.Count > 0)
            {
                Camion camionSeleccionado = dgv_Camiones.SelectedRows[0].DataBoundItem as Camion;
                if(camionSeleccionado != null)
                {
                    if(usuario.BalanceDinero >= camionSeleccionado.Precio)
                    {
                        return 1; // Compra exitosa
                    }
                    else
                    {
                        return 2; // No hay dinero
                    }
                }
                else
                {
                    return 3; // camion no valido
                }
            }
            else
            {
                return 4; // No se ha seleccionado ningun camion
            }
        }

        private void RealizarCompra()
        {
            Camion camionSeleccionado = dgv_Camiones.SelectedRows[0].DataBoundItem as Camion;
            usuario.BalanceDinero -= camionSeleccionado.Precio;
            ActualizarBalanceDinero();

            
            
            Controles.MostrarMensaje($"Compra exitosa! El camión ha sido trasladado a tu garaje", "Compra Exitosa", MessageBoxIcon.Information);
            // Agregamos el ID del camión comprado a la lista del usuario
            usuario.Camiones.Add(camionSeleccionado.Id);

            // Actualizamos la lista de camiones del usuario logeado en la lista de usuarios
            foreach( var user in lista_usuarios)
            {
                if(user.Id == usuario.Id)
                {
                    user.Camiones = usuario.Camiones;
                    user.BalanceDinero = usuario.BalanceDinero;
                    break;
                }
            }
            //usuario.Camiones = usuario.Camiones.Concat(new[] { camionSeleccionado.Id }).ToList();

            // Guardamos la lista actualizada de usuario en el json
            Gestion_Json.Guardar_Archivo(lista_usuarios, @"../../arch_json/usuarios.json");
        }

        public void ActualizarTablaCamion()
        {
            dgv_Camiones.DataSource = null;
            dgv_Camiones.DataSource = lista_camiones;

            dgv_Camiones.Columns["Id"].HeaderText = "ID";
            dgv_Camiones.Columns["Modelo"].HeaderText = "Modelo";
            dgv_Camiones.Columns["Capacidad"].HeaderText = "Capacidad";
            dgv_Camiones.Columns["Estado"].HeaderText = "Estado";
            dgv_Camiones.Columns["Precio"].HeaderText = "Precio";
        }

        public static void ActualizarBalanceDinero()
        {
            // Actualizamos el dinero en el formulario frmHome
            frmHome homeForm = Application.OpenForms.OfType<frmHome>().FirstOrDefault();
            if (homeForm != null)
            {
                homeForm.ActualizarDinero();
            }
        }
        #endregion

        #region Metodos_Clicks
        private void btnComprar_Click(object sender, EventArgs e)
        {
            ComprarCamion();
        }
        #endregion
    }
}