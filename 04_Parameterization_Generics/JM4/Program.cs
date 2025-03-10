using System;

class Program
{
    static void Main()
    {
        // Menampilkan kode buah
        Console.WriteLine("Kode Buah:");
        Console.WriteLine("Apel: " + KodeBuah.GetKodeBuah("Apel"));
        Console.WriteLine("Durian: " + KodeBuah.GetKodeBuah("Durian"));
        Console.WriteLine("Semangka: " + KodeBuah.GetKodeBuah("Semangka"));
        Console.WriteLine("Kurma: " + KodeBuah.GetKodeBuah("Kurma"));

        Console.WriteLine("\nTekan ENTER untuk melanjutkan ke game posisi karakter...");
        Console.ReadLine();

        // Memasukkan NIM untuk menentukan behavior karakter
        int nim;
        Console.Write("Masukkan NIM: ");
        while (!int.TryParse(Console.ReadLine(), out nim))
        {
            Console.WriteLine("NIM harus berupa angka. Coba lagi.");
            Console.Write("Masukkan NIM: ");
        }

        // Simulasi perubahan posisi karakter
        PosisiKarakterGame karakter = new PosisiKarakterGame(nim);
        karakter.UbahPosisi(PosisiKarakterGame.Posisi.Terbang);
        karakter.UbahPosisi(PosisiKarakterGame.Posisi.Jongkok);
        karakter.UbahPosisi(PosisiKarakterGame.Posisi.Berdiri);
        karakter.UbahPosisi(PosisiKarakterGame.Posisi.Tengkurap);

        Console.WriteLine("\nTekan ENTER untuk keluar...");
        Console.ReadLine();
    }
}
