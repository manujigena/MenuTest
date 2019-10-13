using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            string plato;
            int indice;
            List<string> lista = new List<string>();
            do
            {
                Console.Clear();
                Console.WriteLine("1. Agregar plato");
                Console.WriteLine("2. Eliminar plato");
                Console.WriteLine("3. Modificar plato");
                Console.WriteLine("4. Listar platos");
                Console.WriteLine("5. Salir");
                opcion = Console.ReadLine();                
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Ingrese nombre del plato");
                        plato = Console.ReadLine();
                        lista.Add(plato);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Ingrese el numero del plato");
                        indice = int.Parse(Console.ReadLine());
                        int auxInt = indice - 1;
                        Console.WriteLine("Seguro desea eliminar " + lista.ElementAt(auxInt) +"?\nS=si N=no");
                        opcion = Console.ReadLine();
                        if (opcion == "s")
                        {
                            lista.RemoveAt(auxInt);
                        }
                        else
                        {
                            Console.WriteLine("No se elimino el plato");
                        }
                        
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Ingrese el numero del plato");
                        indice = int.Parse(Console.ReadLine());
                        auxInt = indice - 1;
                        Console.WriteLine("Seguro desea cambiar " + lista.ElementAt(auxInt) + "?\nS=si N=no");
                        opcion = Console.ReadLine();
                        if (opcion == "s")
                        {
                            Console.WriteLine("Ingrese nuevo nombre del plato");
                            string nuevoNombre = Console.ReadLine();
                            for (int i = 0; i < lista.Count; i++)
                            {
                                if (i == auxInt)
                                {
                                    lista[i] = nuevoNombre;
                                    Console.WriteLine("Se modifico con exito ahora el plato es " + nuevoNombre);
                                }
                                else
                                {
                                    Console.WriteLine("No se encontro el plato indicado");
                                }
                            }
                        }                        
                        break;
                    case "4":
                        Console.Clear();
                        for (int i = 0; i < lista.Count; i++)
                        {
                            Console.WriteLine((i+1) + ":" + lista[i]);
                        }
                        Console.WriteLine("Presione cualquier tecla para volver al menu");
                        Console.ReadLine();
                        break;                    
                    default:
                        break;
                }

            } while (opcion != "5");
        }

        
    }
}
