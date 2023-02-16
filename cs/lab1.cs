using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.out.println();
            Console.Write("Welcome to spring semester");
            Console.WriteLine("Welcome to C#");

            int ax = 10, bx = 20, cx = 30;
            string z = "hello class";
            Console.WriteLine("ax: " + ax + ", bx: " + bx + ", cx: " + cx);
            //printf("%d", ax);
            Console.WriteLine("ax: {0}, bx: {1}, cx: {2}", ax, z, cx);
            Console.WriteLine("{0}", bx);

            string s1 = Console.ReadLine();
            Console.WriteLine("Output: {0}", s1);

            //string s2 = Console.ReadLine();
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0},{1}", n1 + n2, n1 - n2);

            int a;
            a = 5;
            a++;
        }
    }
}
