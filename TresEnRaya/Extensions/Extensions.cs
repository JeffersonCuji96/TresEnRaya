using System;

namespace TresEnRaya.Extensions
{
    public static class Extensions
    {
        public static bool LetraX(this string letra)
        {
            if (letra == "X")
                return true;
            return false;
        }
        public static bool LetraO(this string letra)
        {
            if (letra == "O")
                return true;
            return false;
        }
        public static bool GanadorO(this string[] array)
        {
            //Horizontales
            bool gana1 = array[0].LetraO() && array[1].LetraO() && array[2].LetraO();
            bool gana2 = array[3].LetraO() && array[4].LetraO() && array[5].LetraO();
            bool gana3 = array[6].LetraO() && array[7].LetraO() && array[8].LetraO();
            //Verticales
            bool gana4 = array[0].LetraO() && array[3].LetraO() && array[6].LetraO();
            bool gana5 = array[1].LetraO() && array[4].LetraO() && array[7].LetraO();
            bool gana6 = array[2].LetraO() && array[5].LetraO() && array[8].LetraO();
            //Diagonales
            bool gana7 = array[0].LetraO() && array[4].LetraO() && array[8].LetraO();
            bool gana8 = array[2].LetraO() && array[4].LetraO() && array[6].LetraO();

            if (gana1 || gana2 || gana3 || gana4 || gana5 || gana6 || gana7 || gana8)
                return true;
            return false;
        }
        public static bool GanadorX(this string[] array)
        {
            //Horizontales
            bool gana1 = array[0].LetraX() && array[1].LetraX() && array[2].LetraX();
            bool gana2 = array[3].LetraX() && array[4].LetraX() && array[5].LetraX();
            bool gana3 = array[6].LetraX() && array[7].LetraX() && array[8].LetraX();
            //Verticales
            bool gana4 = array[0].LetraX() && array[3].LetraX() && array[6].LetraX();
            bool gana5 = array[1].LetraX() && array[4].LetraX() && array[7].LetraX();
            bool gana6 = array[2].LetraX() && array[5].LetraX() && array[8].LetraX();
            //Diagonales
            bool gana7 = array[0].LetraX() && array[4].LetraX() && array[8].LetraX();
            bool gana8 = array[2].LetraX() && array[4].LetraX() && array[6].LetraX();

            if (gana1 || gana2 || gana3 || gana4 || gana5 || gana6 || gana7 || gana8)
                return true;
            return false;
        }
        public static bool Empatado(this string[] array)
        {
            var emp = Array.IndexOf(array, string.Empty);
            if (emp < 0)
                return true;
            return false;
        }
    }
}
