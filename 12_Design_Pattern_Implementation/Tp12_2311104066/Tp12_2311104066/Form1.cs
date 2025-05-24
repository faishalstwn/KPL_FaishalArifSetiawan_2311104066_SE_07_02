using System;
using System.Windows.Forms;

namespace Tpmodul12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(textBoxA.Text, out a) && int.TryParse(textBoxB.Text, out b))
            {
                int hasil = CariNilaiPangkat(a, b);
                labelHasil.Text = $"Hasil: {hasil}";
            }
            else
            {
                labelHasil.Text = "Input tidak valid!";
            }
        }

        public int CariNilaiPangkat(int a, int b)
        {
            if (b == 0) return 1;
            if (b < 0) return -1;
            if (b > 10 || a > 100) return -2;

            int hasil = 1;
            try
            {
                checked
                {
                    for (int i = 0; i < b; i++)
                    {
                        hasil *= a;
                    }
                }
            }
            catch (OverflowException)
            {
                return -3;
            }

            return hasil;
        }
    }
}
