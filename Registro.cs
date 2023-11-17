using System;

namespace Gestor_De_Biblioteca_T3
{
    public class Registro
    {
        private DateTime date;
        private string message;

        public Registro(string message)
        {
            this.date = DateTime.Now;
            this.message = message;
        }
        public Registro(DateTime date, string message)
        {
            this.date = date;
            this.message = message;
        }

        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        public string Message
        {
            get => message;
            set => message = value;
        }
    }
}