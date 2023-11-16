namespace Gestor_De_Biblioteca_T3
{
    public class Reserve
    {
        public string id;
        public Book book;
        public string dateOfReturn;
        public string dateofBooking;

        public Reserve(string id, Book book, string dateOfReturn, string dateofBooking)
        {
            this.id = id;
            this.book = book;
            this.dateOfReturn = dateOfReturn;
            this.dateofBooking = dateofBooking;
        }
    }
}