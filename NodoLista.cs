namespace Gestor_De_Biblioteca_T3
{
    public class NodoLista
    {
        public Registro Valor { get; set; }
        public NodoLista Siguiente { get; set; }

        public NodoLista(Registro valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }
}