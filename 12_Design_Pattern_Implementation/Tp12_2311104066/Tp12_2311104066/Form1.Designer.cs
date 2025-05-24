namespace Tpmodul12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Button buttonHitung;

        private void InitializeComponent()
        {
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelHasil = new System.Windows.Forms.Label();
            this.buttonHitung = new System.Windows.Forms.Button();

            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(30, 30);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(30, 70);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            // 
            // buttonHitung
            // 
            this.buttonHitung.Location = new System.Drawing.Point(30, 110);
            this.buttonHitung.Name = "buttonHitung";
            this.buttonHitung.Size = new System.Drawing.Size(100, 30);
            this.buttonHitung.Text = "Hitung";
            this.buttonHitung.Click += new System.EventHandler(this.buttonHitung_Click);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(30, 160);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Text = "Hasil:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(200, 220);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.buttonHitung);
            this.Controls.Add(this.labelHasil);
            this.Name = "Form1";
            this.Text = "Form1";
        }
    }
}
