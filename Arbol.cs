﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Gestor_De_Biblioteca_T3
{
    public class Arbol
    {
        public NodoArbol raiz;

        private string filePath = "data-tree-books.txt";

        public Arbol()
        {
            raiz = null;
        }

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
                        this.Insert(ref raiz,
                            new Book(
                                dato[0],
                                dato[1],
                                dato[2],
                                dato[3],
                                dato[4]
                            ));
                    }
                }
            }
        }

        public void SaveInPlaneFile(Book dato)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{dato.Id}|{dato.Title}|{dato.Description}|{dato.Author}|{dato.Publication}");
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


        public void Insert(ref NodoArbol r, Book dato)
        {
            if (r == null)
            {
                r = new NodoArbol(dato);
            }
            else
            {
                //comparación del dato que quiero referenciar
                if (String.Compare(dato.Id, r.dato.Id, StringComparison.Ordinal) > 0) //Si es mayor
                    Insert(ref r.der, dato);
                else if (String.Compare(dato.Id, r.dato.Id, StringComparison.Ordinal) < 0) //si es menor
                    Insert(ref r.izq, dato);
                else
                    MessageBox.Show("Elemento duplicado");
            }
        }

        public Book SearchByAuthor(string value)
        {
            return this.SearchByAuthor(value, raiz);
        }

        public Book SearchByAuthor(string value, NodoArbol r)
        {
            Book em = null;
            if (r != null)
            {
                em = r.dato;
                if (value.Contains(em.Author)) return em;
                if (string.Compare(value, em.Author, StringComparison.OrdinalIgnoreCase) < 0)
                    return SearchByAuthor(value, r.izq);
                else
                    return SearchByAuthor(value, r.der);
            }

            return em;
        }

        public Book SearchByTitle(string value)
        {
            return this.SearchByTitle(value, raiz);
        }

        public Book SearchByTitle(string value, NodoArbol r)
        {
            Book em = null;
            if (r != null)
            {
                em = r.dato;
                if (value.Contains(em.Author)) return em;
                if (string.Compare(value, em.Title, StringComparison.OrdinalIgnoreCase) < 0)
                    return SearchByTitle(value, r.izq);
                else
                    return SearchByTitle(value, r.der);
            }

            return em;
        }

        public void PostOrden(NodoArbol r, DataGridView DGV)
        {
            if (r != null)
            {
                DGV.Rows.Add(r.dato.Id, r.dato.Title, r.dato.Description, r.dato.Author, r.dato.Publication);
                PostOrden(r.der, DGV);
                PostOrden(r.izq, DGV);
            }
        }
    }
}