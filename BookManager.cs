using System.Collections.Generic;

namespace Gestor_De_Biblioteca_T3
{
    public class BookManager
    {
        private static Arbol currentBooks;

        public static Arbol CurrentBooks
        {
            get { return currentBooks; }
            set { currentBooks = value; }
        }
    }
}