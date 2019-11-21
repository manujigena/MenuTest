using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCola
{
    class Administrador
    {
        private String pedido;
        public String miPedido
        {
            get { return this.pedido; }            
        }
        private int posicion;
        private Queue<String> cola;

        public Queue<String> MiQueue
        {
            get { return this.cola; }
            set { this.cola = value; }
        }

        public void AgregarElemento(int pedido)
        {            
            this.posicion = this.cola.Count + 1;
            this.pedido = posicion + " - " + pedido;
            this.cola.Enqueue(this.pedido);
        }

        public String EliminarElemento()
        {
            return this.cola.Dequeue();
        }

        public void MostrarQueueFull() {
            foreach (var item in this.cola)
            {
                Console.WriteLine(item);
            }
        }

        public String MostrarUltimoElemento()
        {
            return this.pedido;
        }

        public String MostrarPrimerElemento() {
            return this.cola.Peek();
        }

        public int CantidadDeElementos() {
            return this.cola.Count();
        }

    }
}
