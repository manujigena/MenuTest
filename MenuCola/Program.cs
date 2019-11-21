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
            string plato;
            int pedido;
            int posicion;
            int indice;
            Queue<String> cola;
            //List<string> lista = new List<string>();
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
                        cola = admin.MiQueue;
                        Console.WriteLine("Se creo la cola con exito");                        
                        break;
                    case "2":
                        Console.Clear();
                        if (admin.MiQueue != null) {
                            admin.MiQueue.Clear();
                        }                        
                        Console.WriteLine("Se borro con exito la cola");
                        break;
                    case "3":
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese el numero del pedido");
                            pedido = int.Parse(Console.ReadLine());
                            if (cola != null) {
                                posicion = cola.Count;
                                cola.Enqueue(posicion + "-" + pedido);
                            }                            
                            break;
                        }
                        catch (NullReferenceException e)
                        {
                            throw e;
                        }                        
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Se borrara el primer pedido");
                        cola.Dequeue();
                        break;
                    case "5":
                        Console.Clear();
                        foreach (var item in cola)
                        {
                            Console.WriteLine(item.ToString());
                        }                        
                        break;
                    case "6":
                    default:
                        break;
                }

            } while (opcion != "5");
        }
    }    

}
