using System;
using System.Collections.Generic;

namespace JurnalModul14_2311104066
{
    internal class KodePos
    {
        private static readonly Dictionary<string, string> _kodePosMap = new Dictionary<string, string>
        {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };

        // Menampilkan semua data kode pos ke konsol
        public static void TampilkanSemua()
        {
            Console.WriteLine("===== DAFTAR KODE POS =====");
            foreach (var entry in _kodePosMap)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }

    internal class DoorMachine
    {
        private bool _isLocked = true;
        private bool _isOpen = false;

        public void CurrentState()
        {
            Console.WriteLine($"Status: {(_isLocked ? "Terkunci" : "Terbuka/Terkunci: Tidak")}, Pintu: {(_isOpen ? "Terbuka" : "Tertutup")}");
        }

        public void ToggleLock()
        {
            if (_isOpen)
            {
                Console.WriteLine("Pintu terbuka, tidak bisa mengunci!");
            }
            else
            {
                _isLocked = !_isLocked;
                Console.WriteLine(_isLocked ? "Pintu dikunci." : "Pintu dibuka kuncinya.");
            }
        }

        public void OpenDoor()
        {
            if (_isLocked)
            {
                Console.WriteLine("Tidak bisa membuka pintu, masih terkunci!");
            }
            else
            {
                _isOpen = true;
                Console.WriteLine("Pintu berhasil dibuka.");
            }
        }

        public void CloseDoor()
        {
            if (_isOpen)
            {
                _isOpen = false;
                Console.WriteLine("Pintu ditutup kembali.");
            }
            else
            {
                Console.WriteLine("Pintu sudah dalam keadaan tertutup.");
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            // Menampilkan semua kode pos
            KodePos.TampilkanSemua();

            // Simulasi sistem pintu otomatis
            Console.WriteLine("\n===== PROGRAM DOOR MACHINE =====");
            DoorMachine pintu = new DoorMachine();

            pintu.CurrentState();
            pintu.ToggleLock();
            pintu.OpenDoor();
            pintu.CloseDoor();
            pintu.ToggleLock();

            Console.WriteLine("\nProgram selesai. Tekan Enter untuk keluar.");
            Console.ReadLine();
        }
    }
}
