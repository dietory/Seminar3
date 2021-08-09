using System;

namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string IsStepCorrect(int x0, int y0, int x1, int y1, Chessman chessman)
        {
            if (chessman == Chessman.Ladya)
            {
                if ((Math.Abs(x0 - x1) > 1 && Math.Abs(y0 - y1) == 0) || (Math.Abs(x0 - x1) == 0 && Math.Abs(y0 - y1) > 1))
                    return "Верный ход ладьей";
                else
                    return "Не верный ход ладьей";
            }
            else if (chessman == Chessman.Kon)
            {
                if ((Math.Abs(x0 - x1) == 1 && Math.Abs(y0 - y1) == 2) || (Math.Abs(x0 - x1) == 2 && Math.Abs(y0 - y1) == 1))
                    return "Верный ход конем";
                else
                    return "Не верный ход конем";
            }
            else if (chessman == Chessman.Slon)
            {
                if ((Math.Abs(x0 - x1) == Math.Abs(y0 - y1)))
                    return "Верный ход слоном";
                else
                    return "Не верный ход слоном";
            }
            else if (chessman == Chessman.Ferz)
            {
                return "Верный ход ферзем";
            }
            else if (chessman == Chessman.King)
            {
                if ((Math.Abs(x0 - x1) == 1 || Math.Abs(y0 - y1) == 1) || (Math.Abs(x0 - x1) == Math.Abs(y0 - y1) && Math.Abs(y0 - y1) == 1))
                    return "Верный ход королем";
                else
                    return "Не верный ход королем";
            }
            else
                return "Такой фигуры не существует";

        }
    }

    public enum Chessman
    {
        Slon,
        Kon,
        Ladya,
        Ferz,
        King

    }
}
