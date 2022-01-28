using System;
using TresEnRaya.Data;

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
        public static Tuple<bool,int> GanadorO(this string[] array)
        {
            if (array[0].LetraO() && array[1].LetraO() && array[2].LetraO())
            {
                return Tuple.Create(true, 0);
            }
            else if (array[3].LetraO() && array[4].LetraO() && array[5].LetraO())
            {
                return Tuple.Create(true, 1);
            }
            else if (array[6].LetraO() && array[7].LetraO() && array[8].LetraO())
            {
                return Tuple.Create(true, 2);
            }
            else if (array[0].LetraO() && array[3].LetraO() && array[6].LetraO())
            {
                return Tuple.Create(true, 3);
            }
            else if (array[1].LetraO() && array[4].LetraO() && array[7].LetraO())
            {
                return Tuple.Create(true, 4);
            }
            else if (array[2].LetraO() && array[5].LetraO() && array[8].LetraO())
            {
                return Tuple.Create(true, 5);
            }
            else if (array[0].LetraO() && array[4].LetraO() && array[8].LetraO())
            {
                return Tuple.Create(true, 6);
            }
            else if (array[2].LetraO() && array[4].LetraO() && array[6].LetraO())
            {
                return Tuple.Create(true, 7);
            }
            return Tuple.Create(false, -1);
        }
        public static Tuple<bool,int> GanadorX(this string[] array)
        {
            if(array[0].LetraX() && array[1].LetraX() && array[2].LetraX())
            {
                return Tuple.Create(true, 0);
            }else if(array[3].LetraX() && array[4].LetraX() && array[5].LetraX())
            {
                return Tuple.Create(true, 1);
            }else if(array[6].LetraX() && array[7].LetraX() && array[8].LetraX())
            {
                return Tuple.Create(true, 2);
            }else if(array[0].LetraX() && array[3].LetraX() && array[6].LetraX()){
                return Tuple.Create(true, 3);
            }else if(array[1].LetraX() && array[4].LetraX() && array[7].LetraX())
            {
                return Tuple.Create(true, 4);
            }else if(array[2].LetraX() && array[5].LetraX() && array[8].LetraX())
            {
                return Tuple.Create(true, 5);
            }else if (array[0].LetraX() && array[4].LetraX() && array[8].LetraX())
            {
                return Tuple.Create(true, 6);
            }else if(array[2].LetraX() && array[4].LetraX() && array[6].LetraX())
            {
                return Tuple.Create(true, 7);
            }
            return Tuple.Create(false,-1);
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
