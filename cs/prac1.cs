using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStruct
{
    struct Point 
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintPoint()
        {
            Console.WriteLine("({0},{1})", this.x, this.y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1;
            p1.x = 3;
            p1.y = 5;
            p1.PrintPoint();

            Point p2 = p1;
            p2.x++;
            p2.y--;
            p2.PrintPoint();
            p1.PrintPoint();

            Point p3 = new Point();
            p3.x = -5;
            p3.y = 92;
            p3.PrintPoint();

            Point p4 = new Point(12, -87);
            p4.PrintPoint();

            int u = 10;
            //u = 10;
            u++;
        }
    }
}
