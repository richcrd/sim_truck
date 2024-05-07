using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace SIM_TRUCK.capa_datos
{
    public class Gestion_Json
    {
        private static readonly JsonSerializerOptions json_legible = new JsonSerializerOptions
        {
            WriteIndented = true // Opcional: para que el JSON sea legible
        };

        public static List<T> Cargar_Archivo<T>(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                try
                {
                    string json = File.ReadAllText(rutaArchivo);
                    return JsonSerializer.Deserialize<List<T>>(json);
                }
                catch (Exception ex)
                {
                    throw new Exception("El archivo no pudo deserializarse: " + ex.Message);
                }
            }
            else
            {
                throw new FileNotFoundException("Archivo no encontrado", rutaArchivo);
            }
        }

        public static void Guardar_Archivo<T>(List<T> listaDatos, string rutaArchivo)
        {
            string json = JsonSerializer.Serialize(listaDatos, json_legible);
            File.WriteAllText(rutaArchivo, json);
        }
    }
}