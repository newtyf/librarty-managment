using System;
using System.Windows.Forms;

namespace Gestor_De_Biblioteca_T3
{
    public class Cola
    {
        public NodoCola primero;
        public NodoCola ultimo;

        public Cola()
        {
            primero = ultimo = null;
        }

        public void Encolar(Reserve valor)
        {
            NodoCola aux = new NodoCola();
            aux.dato = valor;

            if (primero == null)
            {
                aux.siguiente = null;
                primero = ultimo = aux;
                primero.atras = null;
            }
            else
            {
                ultimo.siguiente = aux;
                aux.siguiente = null;
                aux.atras = ultimo;
                ultimo = aux;
            }

        }
        
        public int ContarNodos()
        {
            int cant = 0;
            NodoCola puntero;
            puntero = primero;

            while (puntero != null)
            {
                cant++;
                puntero = puntero.siguiente;
            }
            return cant;
        }

        public Reserve Desencolar()
        {
            Reserve valor = null;

            if (primero == null)
            {
                Console.WriteLine("La cola esta vacía");
            }
            else
            {
                valor = primero.dato;
                primero = primero.siguiente;
            }
            return valor;
        }

        public void MostrarDGV(DataGridView DGV)
        {
            DGV.Rows.Clear();
            int id = 0;
            NodoCola puntero;
            puntero = primero;

            if (puntero == null)
            {
                MessageBox.Show("la cola se encuentra vacia");
            }
            else
            {
                do
                {
                    id++;
                    Reserve dato = puntero.dato;
                    DGV.Rows.Add(dato.id, dato.book.Title, dato.dateofBooking, dato.dateOfReturn);
                    puntero = puntero.siguiente;
                } while (puntero != null);

            }

        }
    }
}