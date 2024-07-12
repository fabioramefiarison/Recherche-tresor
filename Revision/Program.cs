using System;

namespace Revision
{
    class Program
    {
        public static void SeDeplacer(int initialX, int initialY, string chemin)
        {
            foreach(char c in chemin)
            {
                if (c == 'N' && initialY > 0) initialY -= 1;
                if (c == 'S' && initialY < 3) initialY += 1;
                if (c == 'E' && initialX < 4) initialX += 1;
                if (c == 'O' && initialX > 0) initialX -= 1;
            }
            Console.WriteLine("x = {0} et y = {1}",initialX, initialY);
        }

        public static string TrouverTresor(int initialX, int initialY, int tresorX, int tresorY)
        {
            string resultat = "";
            int count = 0;
            while(initialX != tresorX || initialY != tresorY)
            {
                count++;
                if (initialX < tresorX)
                {
                    initialX += 1;
                    resultat += "E";
                }
                if (initialX > tresorX)
                {
                    initialX -= 1;
                    resultat += "O";
                }
                if (initialY > tresorY)
                {
                    initialY -= 1;
                    resultat += "N";
                }
                if (initialY < tresorY)
                {
                    initialY += 1;
                    resultat += "S";
                }
            }
            Console.WriteLine("sans else " + count);
            return resultat;
        }

        public static string TrouverTresor2(int initialX, int initialY, int tresorX, int tresorY)
        {
            string resultat = "";
            int count = 0;
            while (initialX != tresorX || initialY != tresorY)
            {
                count++;
                if (initialX < tresorX)
                {
                    initialX += 1;
                    resultat += "E";
                }
                else if (initialX > tresorX)
                {
                    initialX -= 1;
                    resultat += "O";
                }
                else if (initialY > tresorY)
                {
                    initialY -= 1;
                    resultat += "N";
                }
                else if (initialY < tresorY)
                {
                    initialY += 1;
                    resultat += "S";
                }
            }
            Console.WriteLine("avec else " + count);
            return resultat;
        }
        static void Main(string[] args)
        {

            Point p1 = new Point(1, 1);
            Point p2 = new Point(4, 2);
            Terrain t1 = new Terrain(4, 3, p1, p2);
            Console.WriteLine(t1.TrouverTresor());
        }
    }
}
