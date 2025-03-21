using System;
using System.Drawing;
using System.Windows.Forms;

namespace TPMODUL03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            SetupUI();
        }

        private void SetupUI()
        {
            
            this.BackColor = Color.LightGray;

            textBox1.ForeColor = Color.Black;
            textBox1.BackColor = Color.Orange;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;

            button.ForeColor = Color.White;
            button.BackColor = Color.Orange;
            button.Font = new Font("Arial", 10, FontStyle.Bold);
            button.Text = "Submit";
            button.Click += button_Click;

            
            label1.ForeColor = Color.Black;
            label1.Text = "Klik Saya";
            label1.Click += label1_Click;

           
            label2.ForeColor = Color.White;
            label2.BackColor = Color.Orange;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Text = "OUTPUT";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            string namaPraktikan = textBox1.Text;
            label2.Text = "Halo " + namaPraktikan;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label diklik!");
        }
    }
}
