﻿namespace grup_alpro
{
    partial class data_pelanggan
    {
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(340, 34);
            label1.Name = "label1";
            label1.Size = new Size(216, 35);
            label1.TabIndex = 0;
            label1.Text = "DATA PELANGGAN";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(387, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(290, 125);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 2;
            label2.Text = "NAMA";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(290, 231);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 3;
            label3.Text = "ALAMAT";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(290, 177);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 4;
            label4.Text = "NO TELP";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(387, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(387, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 23);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.Font = new Font("Sitka Display", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(549, 272);
            button1.Name = "button1";
            button1.Size = new Size(58, 30);
            button1.TabIndex = 7;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Bisque;
            button2.Font = new Font("Sitka Display", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(387, 272);
            button2.Name = "button2";
            button2.Size = new Size(58, 30);
            button2.TabIndex = 8;
            button2.Text = "ULANG ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // data_pelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(909, 405);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "data_pelanggan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "data_pelanggan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}