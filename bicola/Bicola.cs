using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bicola
{
    internal class Bicola
    {
        private Nodo head;
        private Nodo tail;
        public Bicola()
        {
            head = null;
            tail = null;
        }
        public void AgregarFrente(string dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = dato;
            if (EstaVacia() == true)
            {
                head = nuevo;
                tail = nuevo;
                return;
            }
            head.Anterior = nuevo;
            nuevo.Siguiente = head;
            head = nuevo;
        }
        public void AgregarFinal(string dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = dato;
            if (EstaVacia() == true)
            {
                head = nuevo;
                tail = nuevo;
                return;
            }
            tail.Siguiente = nuevo;
            nuevo.Anterior = tail;
            tail = nuevo;
        }
        public void EliminarFrente()
        {
            if(EstaVacia() == true)
            {
                return;
            }
            if (head.Siguiente == null)
            {
                head = null;
                tail = null;
                return;
            }
            head = head.Siguiente;
            head.Anterior = null;
        }
        public void EliminarFinal()
        {
            if(EstaVacia() == true)
            {
                return;
            }
            if (head.Siguiente == null)
            {
                head = null;
                tail = null;
                return;
            }
            tail = tail.Anterior;
            tail.Siguiente = null;
        }
        public bool EstaVacia()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            string cadena = "";
            Nodo h = head;
            if (EstaVacia() == false)
            {
                cadena += h.ToString();
                h = h.Siguiente;
                while (h != null)
                {
                    cadena += ", " + h.ToString();
                    h = h.Siguiente;
                }
                return cadena;
            }
            else
            {
                return "La cola está vacía.";
            }
        }
    }
}
