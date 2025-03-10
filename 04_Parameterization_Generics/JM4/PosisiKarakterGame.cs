using System;

class PosisiKarakterGame
{
    public enum Posisi { Berdiri, Jongkok, Terbang, Tengkurap }

    private int nim;
    private Posisi posisiSaatIni;

    public PosisiKarakterGame(int nim)
    {
        this.nim = nim;
        posisiSaatIni = Posisi.Berdiri; // Posisi awal
    }

    public void UbahPosisi(Posisi posisiBaru)
    {
        if (posisiSaatIni == posisiBaru)
        {
            Console.WriteLine($"Sudah dalam posisi {posisiBaru}");
            return;
        }

        Console.WriteLine($"Posisi berubah dari {posisiSaatIni} ke {posisiBaru}");

        if (nim % 3 == 0)
        {
            if (posisiBaru == Posisi.Jongkok) Console.WriteLine("Tombol arah bawah ditekan");
            if (posisiBaru == Posisi.Terbang) Console.WriteLine("Tombol arah atas ditekan");
        }
        else if (nim % 3 == 1)
        {
            if (posisiBaru == Posisi.Berdiri) Console.WriteLine("Posisi standby");
            if (posisiBaru == Posisi.Tengkurap) Console.WriteLine("Posisi istirahat");
        }
        else if (nim % 3 == 2)
        {
            if (posisiSaatIni == Posisi.Terbang && posisiBaru == Posisi.Jongkok)
                Console.WriteLine("Posisi landing");

            if (posisiSaatIni == Posisi.Berdiri && posisiBaru == Posisi.Terbang)
                Console.WriteLine("Posisi take off");
        }

        posisiSaatIni = posisiBaru;
    }
}
