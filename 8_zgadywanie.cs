using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odgadnięcie liczby od 1 do 20");
            int większa = 20;
            int mniejsza = 1;
            int x = losowanie(mniejsza, większa);
            Console.ReadKey();
            Console.WriteLine("Czy ta liczba to " + x);
            int i = int.Parse(Console.ReadLine());
            while (i != 0)
            {
                if (i > 0)
                {
                    mniejsza = x + 1;
                    x = losowanie(mniejsza, większa);
                    Console.WriteLine("Czy ta liczba to " + x);
                    i = int.Parse(Console.ReadLine());
                }
                else if (i < 0)
                {
                    większa = x - 1;
                    x = losowanie(mniejsza, większa);
                    Console.WriteLine("czy twoja liczba to " + x);
                    i = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Ta liczba to: " + x);
            Console.ReadKey();

        }
        static int losowanie(int poczatek, int koniec)
        {
            Random rnd = new Random();
            int wylosowana = rnd.Next(poczatek, koniec);
            return wylosowana;
        }
    }
}
