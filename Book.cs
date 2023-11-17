namespace Gestor_De_Biblioteca_T3
{
    public class Book
    {
        private string id;
        private string title;
        private string description;
        private string author;
        private string publication;
        private string cover;
        private string gender;

        public Book()
        {
        }

        public Book(string id, string title, string description, string author, string publication, string cover, string gender)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.author = author;
            this.publication = publication;
            this.cover = cover;
            this.gender = gender;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Publication
        {
            get => publication;
            set => publication = value;
        }
        
        public string Cover
        {
            get => cover;
            set => cover = value;
        }
        
        public string Gender
        {
            get => gender;
            set => gender = value;
        }
    }
}