using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class ClsVendedor2 : ClsVendedores, ClsInterface.Ivendedor2
    {
        public string nombre { get; set; }

        public ClsVendedor2(string nombre)
        {
            nombre = "Victor Diaz";
        }

        public void VentasCredito()
        {
            Console.WriteLine($"Con {nombre}, puede comprar a credito");
            
        }
    }
}
