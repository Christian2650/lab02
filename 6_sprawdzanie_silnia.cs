using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wprowadź liczbę główną: ");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę, aby sprawdzic czy jest ona silnią liczby głównej ");
            double n = Double.Parse(Console.ReadLine());
            if (liczSilnia(n) == x)
            {
                Console.WriteLine(n);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Podana liczba nie jest silnią liczby głównej");
                Console.ReadKey();
            }
        }
        public static double liczSilnia(double n)
        {
            double nSilnia = 1;
            for (int i = 1; i <= n; i++)
            {
                nSilnia = nSilnia * i;
            }
            return nSilnia;

        }
    }
}
