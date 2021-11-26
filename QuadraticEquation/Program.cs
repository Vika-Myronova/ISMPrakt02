using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x, x1, x2, D;
            Console.WriteLine("Введіть a = ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть b = ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть c = ");
            c = double.Parse(Console.ReadLine());
            D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"\nD = {D}");
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
            }
            else if (D == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine($"x = {x}");
            }
            else
            {
                Console.WriteLine("Рівняння розв'язків не має");
            }

        }
    }
}
