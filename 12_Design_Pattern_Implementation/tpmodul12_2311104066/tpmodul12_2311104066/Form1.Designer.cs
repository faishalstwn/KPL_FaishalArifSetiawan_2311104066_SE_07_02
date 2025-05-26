namespace tpmodul12_2311104066
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(30, 30);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(200, 23);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(30, 70);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(200, 30);
            this.buttonCheck.Text = "Cek Tanda";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(30, 110);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(200, 23);
            this.labelResult.Text = "-";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(270, 170);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labelResult);
            this.Name = "Form1";
            this.Text = "TP Modul 12 - 2311104066";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
