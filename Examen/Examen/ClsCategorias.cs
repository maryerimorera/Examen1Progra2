using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class ClsCategorias
    {
        public void Categorias()
        {
            Console.WriteLine("Descuentos y promociones");
        }

        List<int> lista = new List<int> 
        { 
            1, 
            2, 
            3,
        };
        public ClsCategorias() { }
        public void ListadoCategorias()
        {
            Console.WriteLine(lista);
        }
        public void listaCat()
        {
            Console.WriteLine($"Lista de Categorias: ");
            foreach (var item in lista)
            {
                Console.WriteLine($"Categoria: {item}");
            }
            Console.WriteLine();
        }

        public void promocion() { }

        public bool existeCategoria(int numero) { 
            if (lista.Contains(numero)) 
            { Console.WriteLine($"La categoria {numero}"); 
                return true; 
            } else 
                return true; }
        }
     

}

