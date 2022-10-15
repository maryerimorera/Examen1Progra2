using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    
    internal class ClsArticulos
    {
        protected int Codigo { get; set; }
        protected string Nombre { get; set; }
        protected int Precio { get; set; }
        
        static private int i, x, opcion, sumatoria;

        
        public ClsArticulos() { }

        public ClsArticulos(int codigo, string nombre, int precio)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
        }


        static ClsArticulos[] listaArticulos = new ClsArticulos[5];
       
        public void agregarArticulo()
        {

            int num = 1; for (i = 0; i < listaArticulos.Length; i++)
            {
                Console.WriteLine($"Ingrese el codigo del Articulo numero {num}"); Codigo = int.Parse(Console.ReadLine()); Console.WriteLine("Ingrese el nombre del Articulo"); Nombre = Console.ReadLine(); Console.WriteLine("Ingrese el precio del Articulo"); Precio = int.Parse(Console.ReadLine());

                listaArticulos[i] = new ClsArticulos(Codigo, Nombre, Precio);
            }
            Console.WriteLine("Presione Enter para continuar"); 
            Console.ReadKey();

        }


        public void BorrarArticulo()
        {

            i = 0;

            foreach (var articulo in listaArticulos)
            {
                Console.WriteLine($"Articulo numero: {i + 1} \nCodigo: {articulo.Codigo} Nombre: {articulo.Nombre} Precio: {articulo.Precio}");

            }
            Console.WriteLine("Digite el articulo que desea eliminar");
            opcion = int.Parse(Console.ReadLine());
            for (int i = 0; i < listaArticulos.Length; i++)
            {
                if (listaArticulos[i].Codigo == opcion)
                {
                    listaArticulos[i].Codigo = 0;
                    listaArticulos[i].Nombre = "";
                    listaArticulos[i].Precio = 0;
                }
                Console.WriteLine("El articulo ha sido removido de manera exitosa");
            }

        }

        public void ConsultarArticulos()
        {
            for (x = 0; x < 1; x++)
            {
                Console.WriteLine("===================== Detalle de los articulos seleccionados =====================\n");

                Console.WriteLine($"Codigo : {listaArticulos[x].Codigo} \nNombre : {listaArticulos[x].Nombre} \nPrecio : {listaArticulos[x].Precio} \n" +
                    $"============================================================================");

            }

        }

        public void validarArticulo()
        {
            Console.WriteLine("Digite el codigo del producto que desea validar");
            opcion = int.Parse(Console.ReadLine());
            for (int i = 0; i < listaArticulos.Length; i++)
            {
                if (listaArticulos[i].Codigo == opcion)
                {
                    Console.WriteLine($"Detalle del articulo:\n " +
                        $"Nombre : {listaArticulos[i].Nombre}\n" +
                        $"Precio : {listaArticulos[i].Precio}\n");
                }
                else
                {
                    Console.WriteLine("El producto no existe");
                }
            }
        }

        public void sumaArticulos()
        {
            for (int i = 0; i < listaArticulos.Length; i++)
            {
                sumatoria += listaArticulos[x].Precio;
            }

            Console.WriteLine($"El total corresponde a {sumatoria}\n");
        }

       
    }
}
