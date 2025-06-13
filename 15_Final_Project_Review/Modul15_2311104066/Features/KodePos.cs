using System;
using System.Collections.Generic;

namespace Modul15_2311104066.Features
{
    public class KodePos
    {
        private static readonly Dictionary<string, string> kodePosMap = new Dictionary<string, string>
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

        public static void TampilkanSemuaKodePos()
        {
            Console.WriteLine("===== DAFTAR KODE POS =====");
            foreach (var entry in kodePosMap)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}