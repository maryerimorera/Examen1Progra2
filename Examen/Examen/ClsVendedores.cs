using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class ClsVendedores
    {
        private static Dictionary<int, String> Vendedores = new Dictionary<int, string>()
        {

        {1, "Pedro Rodriguez" },
        {2, "Victor Diaz" },

        };

        public ClsVendedores() { }

        public void listadoVendedores()
        {
            foreach (var vendedor in Vendedores)
            {
                Console.WriteLine($"Servicio {vendedor.Key} Nombre: {vendedor.Value}");
            }
        }

        public string consultaVendedores(int value)
        {
            string resultado = "";
            if (Vendedores.TryGetValue(value, out resultado))
            {
                return "El vendedor es: " + resultado;
            }
            else
            {
                return "El vendedor no existe";
            }
        }
    }
}
