using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bicola
{
    internal class Nodo
    {
        private string dato;
        private Nodo siguiente;
        private Nodo anterior;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        public Nodo()
        {
            dato = "";
            siguiente = null;
            anterior = null;
        }
        public override string ToString()
        {
            return dato;
        }
    }
}
