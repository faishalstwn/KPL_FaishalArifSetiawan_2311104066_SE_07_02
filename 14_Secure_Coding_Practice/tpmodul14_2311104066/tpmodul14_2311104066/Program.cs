using System;

namespace TpModul14_2311104066
{
    internal class Program
    {
        static void Main()
        {
            // Input huruf dari pengguna
            Console.Write("Masukkan satu huruf: ");
            char inputHuruf = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            // Cek apakah huruf vokal atau konsonan
            if ("AIUEO".Contains(inputHuruf))
            {
                Console.WriteLine($"Huruf {inputHuruf} merupakan huruf vokal.");
            }
            else
            {
                Console.WriteLine($"Huruf {inputHuruf} merupakan huruf konsonan.");
            }

            // Cetak array angka genap
            int[] angkaGenap = { 2, 4, 6, 8, 10 };

            for (int i = 0; i < angkaGenap.Length; i++)
            {
                Console.WriteLine($"Angka genap ke-{i + 1}: {angkaGenap[i]}");
            }
        }
    }
}
