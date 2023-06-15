using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosimy podać n:");

            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("prosimy podać x:");

            double x = Convert.ToDouble(Console.ReadLine());
            double a = 0;
            Console.WriteLine("Funkcja ex wynosi: " + liczEX(x, n, a));
            Console.ReadKey();

        }
        public static double liczSilnia(double a)
        {
            double nSilnia = 1;
            for (int i = 1; i <= a; i++)
            {
                nSilnia = nSilnia * i;
            }
            Console.WriteLine("silnia: " + nSilnia);
            return nSilnia;

        }
        public static double liczEX(double x, double n, double a)
        {
            double ex = 0;
            for (int i = 0; i < n; i++)
            {

                ex = ex + (Math.Pow(x, i) / liczSilnia(a));
                a++;
            }
            return ex;
        }
    }
}