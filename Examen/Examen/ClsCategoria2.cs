using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class ClsCategoria2 : ClsCategorias
    {
        ClsCategorias categoria = new ClsCategorias();

        public void promocion()
        {
            Console.WriteLine("Promoción dos por 1");
        }
    }
}
