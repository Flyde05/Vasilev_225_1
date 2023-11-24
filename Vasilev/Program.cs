using System;

namespace Vasilev
{
    class Program
    {
        static void Main()
        {
            Console.Write("Insert X1: ");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("Insert X2: ");
            var x2 = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Abs(x2 - x1));
            Console.ReadLine();
        }
    }
}