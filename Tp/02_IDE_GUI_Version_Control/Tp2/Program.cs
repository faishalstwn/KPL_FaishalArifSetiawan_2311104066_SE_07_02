using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Masukkan satu huruf: ");
        char huruf = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();  // Pindah baris setelah input

        
        if ("AIUEO".Contains(huruf))
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");
        }

        
        int[] angkaGenap = { 2, 4, 6, 8, 10 };

        for (int i = 0; i < angkaGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap {i + 1} : {angkaGenap[i]}");
        }
    }
}

