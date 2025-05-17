

using System;
using MatematikaLibraries;

namespace Modul10_12345678
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FPB(60, 45): " + Matematika.FPB(60, 45));
            Console.WriteLine("KPK(12, 8): " + Matematika.KPK(12, 8));

            int[] fungsi1 = { 1, 4, -12, 9 };
            Console.WriteLine("Turunan dari x^3 + 4x^2 - 12x + 9:");
            Console.WriteLine(Matematika.Turunan(fungsi1));

            int[] fungsi2 = { 4, 6, -12, 9 };
            Console.WriteLine("Integral dari 4x^3 + 6x^2 - 12x + 9:");
            Console.WriteLine(Matematika.Integral(fungsi2));
        }
    }
}
