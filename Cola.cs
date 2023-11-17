using System;
using System.IO;
using System.Windows.Forms;

namespace Gestor_De_Biblioteca_T3
{
    public class Cola
    {
        public NodoCola primero;
        public NodoCola ultimo;

        private string filePath = "reserves.txt";

        public void ChargeData()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] dato = linea.Split('|');
                        this.Encolar(
                            new Reserve(
                                dato[0],
                                dato[1],
                                dato[2],
                                dato[3]
                            ));
                    }
                }
            }
        }

        public void SaveInPlaneFile(Reserve dato)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(
                    $"{dato.id}|{dato.book}|{dato.dateOfReturn}|{dato.dateofBooking}");
            }
        }

        public void DeleteInPlaneFile(string datoAEliminar)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                int numLineaAEliminar = -1;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(datoAEliminar))
                    {
                        numLineaAEliminar = i;
                        break;
                    }
                }

                if (numLineaAEliminar >= 0)
                {
                    string[] newLines = new string[lines.Length - 1];
                    for (int i = 0, j = 0; i < lines.Length; i++)
                    {
                        if (i != numLineaAEliminar)
                        {
                            newLines[j] = lines[i];
                            j++;
                        }
                    }

                    // Escribir el contenido actualizado en el archivo
                    File.WriteAllLines(filePath, newLines);
                }
                else
                {
                    Console.WriteLine("No se encontró el dato específico en ninguna línea.");
                }
            }
        }


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
                    DGV.Rows.Add(dato.id, dato.book, dato.dateofBooking, dato.dateOfReturn);
                    puntero = puntero.siguiente;
                } while (puntero != null);
            }
        }
    }
}