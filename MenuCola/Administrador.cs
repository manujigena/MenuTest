using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCola
{
    class Administrador
    {
        protected int pedido;
        protected int posicion;
        protected Queue<String> cola;

        public Queue<String> MiQueue
        {
            get { return this.cola; }
            set { this.cola = new Queue<string>(); }
        }

        public void AgregarElemento(int pedido)
        {
            this.posicion = this.cola.Count;
            this.cola.Enqueue(posicion + "" + pedido);
        }

        public void EliminarElemento()
        {
            this.cola.Dequeue();
        }

    }
}
