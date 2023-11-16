using System.IO;

namespace Gestor_De_Biblioteca_T3
{
    public class User
    {
        public string name;
        public string username;
        public string password;

        public User()
        {
        }

        public User(string name, string username, string password)
        {
            this.name = name;
            this.username = username;
            this.password = password;
        }

        public static User LoginUser(string username, string password)
        {
            string filePath = "users.txt"; // Ruta del archivo que deseas leer
            User user = null;
            
            if (File.Exists(filePath))
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string linea;
                    
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] users = linea.Split('|');
                        // Procesa la línea como desees, por ejemplo, imprímela en la consola
                        if (users[1].Equals(username) && users[2].Equals(password) )
                        {
                            user = new User(users[0],users[1],users[2]);
                        }
                    }
                }
            }

            return user;
        }
    }
    
}