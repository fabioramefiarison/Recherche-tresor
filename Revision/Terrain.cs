using System;
using System.Collections.Generic;
using System.Text;

namespace Revision
{
    class Terrain
    {
        public int DimensionX { get; set; }
        public int DimensionY { get; set; }
        public Point PointInitial { get; set; }
        public Point Tresor { get; set; }

        public Terrain(int x, int y, Point initial, Point tresor)
        {
            this.DimensionX = x;
            this.DimensionY = y;
            this.PointInitial = initial;
            this.Tresor = tresor;
        }

        public string TrouverTresor()
        {
            string resultat = "";
            int count = 0;
            while (this.PointInitial.X != this.Tresor.X || this.PointInitial.Y != this.Tresor.Y)
            {
                count++;
                if (this.PointInitial.X < this.Tresor.X)
                {
                    this.PointInitial.X += 1;
                    resultat += "E";
                }
                if (this.PointInitial.X > this.Tresor.X)
                {
                    this.PointInitial.X -= 1;
                    resultat += "O";
                }
                if (this.PointInitial.Y > this.Tresor.Y)
                {
                    this.PointInitial.Y -= 1;
                    resultat += "N";
                }
                if (this.PointInitial.Y < this.Tresor.Y)
                {
                    this.PointInitial.Y += 1;
                    resultat += "S";
                }
            }
            Console.WriteLine("sans else " + count);
            return resultat;
        }


    }
}
