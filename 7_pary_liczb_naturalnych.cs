using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę, dla której mają zostać wypisane wszystkie pary liczb naturalnych, których suma jest równa wprowadzonej liczbie n");
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = 0;
                a = SprawdzCzyNaturalna(a);
                for (int i = 1; b != a / 2; i++)
                {
                    int pierwsza = a - i;
                    Console.Write(pierwsza);
                    Console.WriteLine(" " + i);
                    b++;
                }
                Console.ReadKey();
            }
            static int SprawdzCzyNaturalna(int a)
            {
                while (a < 0 | a % 1 != 0)
                {
                    Console.WriteLine("Podaj liczbę naturalną dla podstawy");
                    a = int.Parse(Console.ReadLine());
                }
                return a;
            }
        }

    }
}
