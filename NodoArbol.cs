namespace Gestor_De_Biblioteca_T3
{
    public class NodoArbol
    {
        public Book dato;
        public NodoArbol izq, der;

        public NodoArbol(Book dato)
        {
            this.dato = dato;
            izq = der = null;
        }
    }
}