using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCola
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            int pedido;            
            Administrador admin = new Administrador();
            
            do
            {
                Console.Clear();
                Console.WriteLine("1. Crear cola");
                Console.WriteLine("2. Borrar cola");
                Console.WriteLine("3. Agregar pedido");
                Console.WriteLine("4. Borrar pedido");
                Console.WriteLine("5. Listar todos los pedidos");
                Console.WriteLine("6. Listar ultimo pedido");
                Console.WriteLine("7. Listar primer pedido");
                Console.WriteLine("8. Cantidad de pedidos");
                Console.WriteLine("9. Salir");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        admin.MiQueue = new Queue<string>();
                        Console.WriteLine("Se creo la cola con exito");
                        Console.ReadLine();
                        break;
                    case "2":
                        //El colector de basura mata cualquier variable en null, la elimina de memoria
                        Console.Clear();
                        if (admin.MiQueue != null) {
                            admin.MiQueue = null;
                        }                        
                        Console.WriteLine("Se borro con exito la cola");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese numero del pedido");
                        pedido = int.Parse(Console.ReadLine());
                        admin.AgregarElemento(pedido);
                        Console.WriteLine("Se agrego con exito " + admin.miPedido);
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Se borra primer pedido");
                        Console.WriteLine(admin.EliminarElemento());
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Lista Completa");
                        admin.MostrarQueueFull();
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine(admin.MostrarUltimoElemento());
                        Console.ReadLine();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine(admin.MostrarPrimerElemento());
                        Console.ReadLine();
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine(admin.CantidadDeElementos());
                        Console.ReadLine();
                        break;                    
                    default:
                        break;
                }

            } while (opcion != "9");
        }
    }    

}
