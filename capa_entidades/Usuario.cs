using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TRUCK.capa_entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public int BalanceDinero { get; set; }
        public List<int> Choferes { get; set; }
        public List<int> Camiones { get; set; }
        public List<int> Viajes { get; set; }

        public Usuario(int id, string nombre, string contrasena, int balanceDinero, List<int> choferes, List<int> camiones, List<int> viajes)
        {
            Id = id;
            Nombre = nombre;
            Contrasena = contrasena;
            BalanceDinero = balanceDinero;
            Choferes = choferes;
            Camiones = camiones;
            Viajes = viajes;
        }
    }
}
