using System;
using System.IO;
using System.Windows.Forms;

namespace Gestor_De_Biblioteca_T3
{
    public class Lista
    {
        private NodoLista cabeza;
        
                private string filePath = "logs.txt";

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
                        this.InsertarAlFinal(
                            new Registro(
                                DateTime.Parse(dato[0]),
                                dato[1]
                            ));
                    }
                }
            }
        }

        public void SaveInPlaneFile(Registro dato)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(
                    $"{dato.Date}|{dato.Message}");
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

        public void InsertarAlPrincipio(Registro valor)
        {
            NodoLista nuevoNodo = new NodoLista(valor);
            nuevoNodo.Siguiente = cabeza;
            cabeza = nuevoNodo;
        }

        public void InsertarAlFinal(Registro valor)
        {
            NodoLista nuevoNodo = new NodoLista(valor);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                return;
            }

            NodoLista actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            actual.Siguiente = nuevoNodo;
        }

        public void imprimirDGV(DataGridView dgv)
        {
            dgv.Rows.Clear();

            NodoLista p = cabeza;

            while (p != null)
            {
                dgv.Rows.Add(p.Valor.Date.ToShortDateString(),
                    p.Valor.Message);
                p = p.Siguiente; //permite recorrer secuencialmente la lista
            }
        }

    }
}