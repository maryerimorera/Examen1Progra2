using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class ClsMenu
    { 
        //Objetos
        static ClsArticulos articulo = new ClsArticulos();
        static ClsVendedores vendedor = new ClsVendedores();
        static ClsCategorias categoria = new ClsCategorias();


        //variables
        static bool validarOpcion = true;
        static int opcion;
        
        //metodos
        public void menu()
        {

            do
            {
                Console.WriteLine("Menu inicial" + "\n\n1-Articulo. \n2-Facturacion. \n 3-Reporte. \n4-Salir. " +
                 "Ingrese la opcion deseada...");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        menuArticulos();
                        break;
                    case 2:
                        menuFacturacion();
                        break;
                    case 3:
                        menuReporte();
                        break;
                    case 4:
                        Console.WriteLine("La opcion ingresada no es valida. \nIntente de nuevo.");

                        break;
                    default:
                        Console.WriteLine("La opcion ingresada no es valida. \nIntente de nuevo.");
                        break;


                }
            } while (opcion != 4);
            Console.Write("Gracias por utilizar nuestro sistema");
        }

        public static void menuArticulos()
        {
            while (validarOpcion)
            {

                Console.WriteLine("Digite el numero de la opcion que desea ingresar: \n" +
                "1-Agregar Articulos\n" +
                "2-Eliminar Articulos\n" +
                "3-Consultar Articulos" +
                "4-Salir");

                opcion = int.Parse(Console.ReadLine());

                {
                    switch (opcion)
                    {
                        case 1:
                            articulo.agregarArticulo();
                            validarOpcion = false;
                            menuArticulos();
                            break;
                        case 2:
                            articulo.BorrarArticulo();
                            validarOpcion = false;
                            menuArticulos();
                            break;
                        case 3:
                            articulo.ConsultarArticulos();
                            validarOpcion = false;
                            menuArticulos();
                            break;
                        case 4:

                            validarOpcion = false;
                            Console.WriteLine("Gracias por usar nuestro sistema");
                            break;
                        default:
                            Console.WriteLine("La opcion ingresada no es valida. \nIntentelo de nuevo.");
                            break;
                    }
                }
            }
        }


        public static void menuFacturacion()
        {
            while (validarOpcion)
            {

                Console.WriteLine("Digite una opcion: \n" +
                "1-Facturacion\n" +
                "2-Salir");

                opcion = int.Parse(Console.ReadLine());
                {
                    switch (opcion)
                    {
                        case 1:
                            articulo.validarArticulo();
                            Console.WriteLine("Ingrese el nombre del vendedor");
                            opcion = int.Parse(Console.ReadLine());
                            Console.WriteLine(vendedor.consultaVendedores(opcion));
                            articulo.sumaArticulos();

                            validarOpcion = false;
                            menuFacturacion();
                            break;
                       
                        case 2:

                            validarOpcion = false;
                            Console.WriteLine("Gracias por usar nuestro sistema");
                            break;
                        default:
                            Console.WriteLine("La opcion ingresada no es valida. \nIntentelo de nuevo.");
                            break;
                    }
                }
            }
        }

        public static void menuReporte()
        {
            while (validarOpcion)
            {

                Console.WriteLine("Digite una opcion: \n" +
                "1-Informacion sobre vendedores, categorias y articulos ingresos\n" +
                "2-Salir");

                opcion = int.Parse(Console.ReadLine());
                {
                    switch (opcion)
                    {
                        case 1:
                            vendedor.listadoVendedores();
                            categoria.listaCat();
                            articulo.ConsultarArticulos();
                            validarOpcion = false;
                            menuReporte();
                            break;

                        case 2:

                            validarOpcion = false;
                            Console.WriteLine("Gracias por usar nuestro sistema");
                            break;
                        default:
                            Console.WriteLine("La opcion ingresada no es valida. \nIntentelo de nuevo.");
                            break;
                    }
                }
            }

        }
    }

}
