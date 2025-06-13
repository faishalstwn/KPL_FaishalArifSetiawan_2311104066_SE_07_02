using Modul15_2311104066.Services;
using Modul15_2311104066.Features;
using Modul15_2311104066.Models;

class Program
{
    static void Main()
    {
        var db = new SecureUserDatabase();

        Console.WriteLine("=== SELAMAT DATANG ===");
        Console.WriteLine("1. Registrasi\n2. Login");
        Console.Write("Pilih opsi (1/2): ");
        string opsi = Console.ReadLine();

        bool loginBerhasil = false;
        string username = "";

        if (opsi == "1")
        {
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (db.Register(username, password))
            {
                Console.WriteLine("Registrasi berhasil, silakan login.");
            }
        }

        if (opsi == "2")
        {
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            loginBerhasil = db.Login(username, password);
            Console.WriteLine(loginBerhasil ? "Login berhasil!" : "Login gagal!");
        }

        if (loginBerhasil)
        {
            Console.Clear();
            Console.WriteLine("=== MENU PROGRAM ===");
            Console.WriteLine("1. Tampilkan Kode Pos");
            Console.WriteLine("2. Jalankan Door Machine");

            Console.Write("Pilih opsi (1/2): ");
            string pilihan = Console.ReadLine();

            if (pilihan == "1")
            {
                KodePos.TampilkanSemuaKodePos();
            }
            else if (pilihan == "2")
            {
                DoorMachine pintu = new DoorMachine();
                pintu.CurrentState();
                pintu.ToggleLock();
                pintu.OpenDoor();
                pintu.CloseDoor();
                pintu.ToggleLock();
            }
        }

        Console.WriteLine("\nTekan Enter untuk keluar.");
        Console.ReadLine();
    }
}