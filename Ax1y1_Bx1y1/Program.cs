using System;

namespace Ax1y1_Bx1y1
{
    public class Points 
    {
        public Points(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double x { get; set; }
        public double y { get; set; }

        public static double Distance(Points p1, Points p2) //нахождение расстояния между точками
        {
            return Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x)
                             + (p1.y - p2.y) * (p1.y - p2.y));
        }

        public double Distance(Points p2) //во избежание перегрузки
        {
            return Math.Sqrt((this.x - p2.x) * (this.x - p2.x)
                             + (this.y - p2.y) * (this.y - p2.y));
        }
    }


    internal class Program
    {
        static void Main(string[] args)
           
        {
            Points point1 = new Points(5, 4);
            Points point2 = new Points(-4, 5);

            Console.WriteLine(Points.Distance(point1, point2)); 

            Console.ReadKey();
        }
    }


}
