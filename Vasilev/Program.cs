using System;

namespace Vasilev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стороны А и B по очереди: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double S = a * b;
            double P = 2 * (a + b);
            Console.WriteLine("Периметр (P) = {0}, Площадь (S) = {1}", P, S);
        }
    }
}