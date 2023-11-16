namespace Gestor_De_Biblioteca_T3
{
    public class ReserveManager
    {
        private static Cola currentReserves;

        public static Cola CurrentReserves
        {
            get { return currentReserves; }
            set { currentReserves = value; }
        }
    }
}