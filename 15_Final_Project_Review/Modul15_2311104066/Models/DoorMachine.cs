namespace Modul15_2311104066.Models
{
    public class DoorMachine
    {
        private bool isLocked = true;
        private bool isOpen = false;

        public void CurrentState()
        {
            Console.WriteLine($"Pintu saat ini: {(isOpen ? "Terbuka" : "Tertutup")}, {(isLocked ? "Terkunci" : "Tidak Terkunci")}");
        }

        public void ToggleLock()
        {
            isLocked = !isLocked;
            Console.WriteLine($"Pintu {(isLocked ? "dikunci" : "dibuka kuncinya")}");
        }

        public void OpenDoor()
        {
            if (isLocked)
                Console.WriteLine("Tidak bisa membuka pintu karena terkunci.");
            else
            {
                isOpen = true;
                Console.WriteLine("Pintu berhasil dibuka.");
            }
        }

        public void CloseDoor()
        {
            if (isOpen)
            {
                isOpen = false;
                Console.WriteLine("Pintu berhasil ditutup.");
            }
            else
            {
                Console.WriteLine("Pintu sudah tertutup.");
            }
        }
    }
}