﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpmodul8_2311104066
{
    class Program
    {
        static void Main(string[] args)
        {
            CovidConfig config = CovidConfig.LoadConfig();

            config.UbahSatuan();

            Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}: ");
            double suhu = Convert.ToDouble(Console.ReadLine());

            Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
            int hariDemam = Convert.ToInt32(Console.ReadLine());

            bool suhuNormal = false;

            if (config.satuan_suhu == "celcius")
            {
                suhuNormal = suhu >= 36.5 && suhu <= 37.5;
            }
            else if (config.satuan_suhu == "fahrenheit")
            {
                suhuNormal = suhu >= 97.7 && suhu <= 99.5;
            }

            bool hariAman = hariDemam < config.batas_hari_deman;

            if (suhuNormal && hariAman)
            {
                Console.WriteLine(config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(config.pesan_ditolak);
            }
        }
    }
}
