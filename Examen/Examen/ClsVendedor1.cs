using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class ClsVendedor1 : ClsVendedores, ClsInterface.Ivendedor1
    {
        public string nombre { get; set; }

        public ClsVendedor1(string nombre)
        {
            nombre = "Pedro Rodriguez";
        }

        public void VentasContado()
        {
            Console.WriteLine($"Con {nombre}, puede comprar de contado");
        }
        
    }
}
