namespace Gestor_De_Biblioteca_T3
{
    public class RegistroManager
    {
        private static Lista currentRegister;

        public static Lista CurrentRegister
        {
            get { return currentRegister; }
            set { currentRegister = value; }
        }
    }
}