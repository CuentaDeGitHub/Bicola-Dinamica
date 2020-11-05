using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiCola_Dinamica
{
    class Cola
    {
        private Nodo head;

        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }

        private Nodo tail;

        public Nodo Tail
        {
            get { return head; }
            set { head = value; }
        }
        public Cola()
        {
            head = null;
            tail = null;
        }
        public void EncolarDerecha(Nodo n)
        {
            if (EstaVacia())
            {
                head = n;
                tail = n;
            }
            else
            {
                tail.Siguiente = n;
                n.Anterior = tail;
                tail = n;
            }
        }
        public void EncolarIzquierda(Nodo n)
        {   
            if (EstaVacia())
            {
                head = n;
                tail = n;
            }
            else
            {
                head.Anterior = n;
                n.Siguiente = head;
                head = n;   
            }
        }

        public void DesencolarIzquierda()
        {
            if(head == null)
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
        public void DesencolarDerecha()
        {
            if(head.Siguiente == null)
            {
                head = null;
                return;
            }
            tail = tail.Anterior;
            tail.Siguiente = null;
        }

        public bool EstaVacia()
        {
            if(head == null)
            {
                return true;
            }
            return false;
        }
        public int Front()
        {
            return head.Dato;
        }
        public override string ToString()
        {
            string stringCola = "";
            Nodo h = head;
            if (h != null)
            {
                stringCola += h.ToString();
                h = h.Siguiente;
                while (h != null)
                {
                    //lista += h.ToString() + ",";  
                    stringCola += "," + h.ToString();
                    h = h.Siguiente;
                }
                return stringCola;
            }
            else
            {
                return "La lista esta vacia";
            }
        }
        
    }
}
