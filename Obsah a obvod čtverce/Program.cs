using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsah_a_obvod_čtverce
{
    class Program
    {
        static void Main(string[] args)
        {
            double strana = 0;

            Console.Write("Zadejte stranu: ");
            strana = double.Parse(Console.ReadLine());

            double obvod = 4 * strana;
            double obsah = strana * strana;

            Console.WriteLine("Obvod je: {0}", obvod);
            Console.WriteLine("Obsah je: {0}", obsah);
            Console.ReadKey();
        }
    }
}
