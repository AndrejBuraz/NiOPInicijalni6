using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napišite program koji će izračunati sumu reda:
                1/3 + 1/9 + 1/27 + . . .
                Korisnik treba unijeti broj članova reda.
             */
            Console.WriteLine("Unesi broj članova reda: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double suma = 0, stupanj = 3.0;
            for (int i = 0; i < n; i++)
            {
                suma += (1 / stupanj);
                stupanj *= 3;
            }
            Console.WriteLine("Suma: " + suma);
            Console.ReadKey();
        }
    }
}
