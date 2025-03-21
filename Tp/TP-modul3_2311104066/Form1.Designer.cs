using System;

namespace TPMODUL03
{
    partial class Form1
    {
        private const System.Windows.Forms.HorizontalAlignment center = System.Windows.Forms.HorizontalAlignment.Center;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.textBox1.Location = new System.Drawing.Point(84, 168);
            this.textBox1.MinimumSize = new System.Drawing.Size(150, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = " FAISHAL";
            this.textBox1.TextAlign = center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.OrangeRed;
            this.button.Location = new System.Drawing.Point(551, 168);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(195, 35);
            this.button.TabIndex = 1;
            this.button.Text = "BUTTON";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 256);
            this.label1.MaximumSize = new System.Drawing.Size(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            InitializeLabel1ClickEvent();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(81, 302);
            this.label2.MaximumSize = new System.Drawing.Size(50, 50);
            this.label2.MinimumSize = new System.Drawing.Size(600, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "OUTPUT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeLabel1ClickEvent()
        {
            this.label1.Click += new System.EventHandler(this.label1_Click);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

