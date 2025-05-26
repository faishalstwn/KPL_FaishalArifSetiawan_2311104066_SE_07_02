using System;
using System.Windows.Forms;

namespace tpmodul12_2311104066
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInput.Text, out int number))
            {
                string result = CariTandaBilangan(number);
                labelResult.Text = result;
            }
            else
            {
                labelResult.Text = "Input tidak valid!";
            }
        }

        public string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }
    }
}
