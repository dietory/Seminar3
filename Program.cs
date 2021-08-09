using System;

namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool AreIntersect(int a, int b, int c, int d)
        {
            if ((a < c && b > c) || (c < a && d > a))
                return true;
            else
                return false;
        }
        public static bool HappyTicket (int ticketNumber)
        {
            string tnLess = (ticketNumber - 1).ToString();
            string tnMore = (ticketNumber + 1).ToString();
            bool htLess = (Convert.ToInt32(tnLess[0]) + Convert.ToInt32(tnLess[1]) + Convert.ToInt32(tnLess[2]))
                == (Convert.ToInt32(tnLess[3]) + Convert.ToInt32(tnLess[4]) + Convert.ToInt32(tnLess[5]));
            bool htMore = (Convert.ToInt32(tnMore[0]) + Convert.ToInt32(tnMore[1]) + Convert.ToInt32(tnMore[2]))
                == (Convert.ToInt32(tnMore[3]) + Convert.ToInt32(tnMore[4]) + Convert.ToInt32(tnMore[5]));
            return htLess || htMore;
        }

        public static bool Prolezet(int x, int y, int z, int a, int b)
        {
            if (CompareXYAB(x, y, a, b) || CompareXYAB(x, z, a, b) || CompareXYAB(z, y, a, b))
                return true;
            else
                return false;
        }

        public static bool CompareXYAB(int x, int y, int a, int b)
        {
            if ((x == a && y == b) || (y == a && x == b))
                return true;
            else
                return false;
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
