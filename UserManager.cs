namespace Gestor_De_Biblioteca_T3
{
    public class UserManager
    {
        private static User currentUser;

        public static User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
    }
}