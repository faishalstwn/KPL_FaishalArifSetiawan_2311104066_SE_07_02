using System;
using AljabarLibraries;

namespace TpModul10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PERSAMAAN KUADRAT ===");

            
            double[] persamaan1 = { 1, -3, -10 }; // x^2 - 3x - 10 = 0
            double[] akar = Aljabar.AkarPersamaanKuadrat(persamaan1);

            Console.WriteLine($"Akar dari x^2 - 3x - 10 = 0: {akar[0]}, {akar[1]}");

            
            double[] persamaan2 = { 2, -3 }; // 2x - 3
            double[] hasilKuadrat = Aljabar.HasilKuadrat(persamaan2);

            Console.WriteLine($"Hasil kuadrat dari (2x - 3)^2: {hasilKuadrat[0]}x^2 + {hasilKuadrat[1]}x + {hasilKuadrat[2]}");
        }
    }
}
