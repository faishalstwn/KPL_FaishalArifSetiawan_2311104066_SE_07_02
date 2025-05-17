
using System;
using System.Text;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public static int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int KPK(int a, int b)
        {
            return Math.Abs(a * b) / FPB(a, b);
        }

        public static string Turunan(int[] koefisien)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < koefisien.Length - 1; i++)
            {
                int pangkat = koefisien.Length - 1 - i;
                int koefTurunan = koefisien[i] * pangkat;

                if (koefTurunan == 0) continue;

                if (sb.Length > 0)
                    sb.Append(koefTurunan > 0 ? " + " : " - ");
                else if (koefTurunan < 0)
                    sb.Append("-");

                sb.Append(Math.Abs(koefTurunan));
                if (pangkat - 1 > 0)
                    sb.Append("x" + (pangkat - 1));
            }
            return sb.ToString();
        }

        public static string Integral(int[] koefisien)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < koefisien.Length; i++)
            {
                int pangkat = koefisien.Length - i;
                double hasil = (double)koefisien[i] / pangkat;

                if (hasil == 0) continue;

                if (sb.Length > 0)
                    sb.Append(hasil > 0 ? " + " : " - ");
                else if (hasil < 0)
                    sb.Append("-");

                sb.Append(Math.Abs(hasil));
                if (pangkat > 1)
                    sb.Append("x" + pangkat);
            }

            sb.Append(" + C");
            return sb.ToString();
        }
    }
}
