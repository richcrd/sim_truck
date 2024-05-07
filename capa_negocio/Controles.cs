using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIM_TRUCK.capa_entidades;

namespace SIM_TRUCK.capa_negocio
{
    public class Controles
    {
        public static bool TextBoxEstaVacio(params TextBox[] txt)
        {
            foreach (TextBox textBox in txt)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    return true;
                }
            }
            return false;
        }

        public static void LimpiarTxt(params TextBox[] txts)
        {
            foreach (TextBox txt in txts)
            {
                txt.Clear();
            }
        }
        public static DialogResult MostrarDialogo(string mensaje, string titulo, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);
            return resultado;
        }

        public static void MostrarMensaje(string msj, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(msj, titulo, MessageBoxButtons.OK, icono);
        }

        //public static T ObtenerElementoSeleccionado<T>(DataGridView tb) where T : class
        //{
        //    if(tb.SelectedRows.Count > 0)
        //    {
        //        return tb.SelectedRows[0].DataBoundItem as T;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
    }
}
