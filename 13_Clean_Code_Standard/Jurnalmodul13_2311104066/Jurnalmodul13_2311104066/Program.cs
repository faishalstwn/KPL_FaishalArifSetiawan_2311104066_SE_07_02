using Jurnalmodul13_2311104066;
using System;

namespace tpmodul13_2311104066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data1 = PusatDataSingleton.GetDataSingleton();
            var data2 = PusatDataSingleton.GetDataSingleton();

            // Tambahkan nama anggota kelompok dan asisten praktikum
            data1.AddSebuahData("stevan");
            data1.AddSebuahData("Stevani");
            data1.AddSebuahData("Asprak: Gideon");

            // Print data dari data2 (seharusnya sama dengan data1)
            Console.WriteLine("Data dari data2:");
            data2.PrintSemuaData();

            // Hapus data asisten dari data2
            data2.HapusSebuahData(2);

            // Print ulang dari data1 (asisten harus sudah hilang)
            Console.WriteLine("\nSetelah dihapus, data dari data1:");
            data1.PrintSemuaData();

            // Tampilkan jumlah data dari kedua variabel
            Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData().Count}");
            Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData().Count}");
        }
    }
}
