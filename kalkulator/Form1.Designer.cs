﻿namespace kalkulator
{
    partial class Form1
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
            this.txtinput = new System.Windows.Forms.TextBox();
            this.txthasil = new System.Windows.Forms.TextBox();
            this.btnc = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnkali = new System.Windows.Forms.Button();
            this.btnbagi = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnkurang = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnsamadengan = new System.Windows.Forms.Button();
            this.btntitik = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnkl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtinput
            // 
            this.txtinput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtinput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinput.Location = new System.Drawing.Point(9, 57);
            this.txtinput.Multiline = true;
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(359, 41);
            this.txtinput.TabIndex = 0;
            this.txtinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txthasil
            // 
            this.txthasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthasil.Location = new System.Drawing.Point(9, 12);
            this.txthasil.Multiline = true;
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(359, 39);
            this.txthasil.TabIndex = 1;
            this.txthasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnc
            // 
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc.Location = new System.Drawing.Point(12, 104);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(84, 57);
            this.btnc.TabIndex = 2;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnce
            // 
            this.btnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnce.Location = new System.Drawing.Point(102, 104);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(84, 57);
            this.btnce.TabIndex = 3;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = true;
            // 
            // btnhapus
            // 
            this.btnhapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.Location = new System.Drawing.Point(194, 104);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(84, 57);
            this.btnhapus.TabIndex = 4;
            this.btnhapus.Text = "<=";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnkali
            // 
            this.btnkali.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkali.Location = new System.Drawing.Point(285, 104);
            this.btnkali.Name = "btnkali";
            this.btnkali.Size = new System.Drawing.Size(84, 57);
            this.btnkali.TabIndex = 5;
            this.btnkali.Text = "X";
            this.btnkali.UseVisualStyleBackColor = true;
            this.btnkali.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnbagi
            // 
            this.btnbagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbagi.Location = new System.Drawing.Point(285, 167);
            this.btnbagi.Name = "btnbagi";
            this.btnbagi.Size = new System.Drawing.Size(84, 57);
            this.btnbagi.TabIndex = 9;
            this.btnbagi.TabStop = false;
            this.btnbagi.Text = ":";
            this.btnbagi.UseVisualStyleBackColor = true;
            this.btnbagi.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(194, 167);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(84, 57);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(102, 167);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(84, 57);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 167);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(84, 57);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btnkurang
            // 
            this.btnkurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkurang.Location = new System.Drawing.Point(285, 230);
            this.btnkurang.Name = "btnkurang";
            this.btnkurang.Size = new System.Drawing.Size(84, 57);
            this.btnkurang.TabIndex = 13;
            this.btnkurang.TabStop = false;
            this.btnkurang.Text = "-";
            this.btnkurang.UseVisualStyleBackColor = true;
            this.btnkurang.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(194, 230);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(84, 57);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(102, 230);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(84, 57);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 230);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(84, 57);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btntambah
            // 
            this.btntambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.Location = new System.Drawing.Point(285, 293);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(84, 57);
            this.btntambah.TabIndex = 17;
            this.btntambah.TabStop = false;
            this.btntambah.Text = "+";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(192, 293);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(84, 57);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(102, 293);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(84, 57);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 293);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(84, 57);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btnsamadengan
            // 
            this.btnsamadengan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsamadengan.Location = new System.Drawing.Point(285, 356);
            this.btnsamadengan.Name = "btnsamadengan";
            this.btnsamadengan.Size = new System.Drawing.Size(84, 57);
            this.btnsamadengan.TabIndex = 21;
            this.btnsamadengan.TabStop = false;
            this.btnsamadengan.Text = "=";
            this.btnsamadengan.UseVisualStyleBackColor = true;
            this.btnsamadengan.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btntitik
            // 
            this.btntitik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntitik.Location = new System.Drawing.Point(194, 356);
            this.btntitik.Name = "btntitik";
            this.btntitik.Size = new System.Drawing.Size(84, 57);
            this.btntitik.TabIndex = 20;
            this.btntitik.Text = ".";
            this.btntitik.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(102, 356);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(84, 57);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btnkl
            // 
            this.btnkl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkl.Location = new System.Drawing.Point(12, 356);
            this.btnkl.Name = "btnkl";
            this.btnkl.Size = new System.Drawing.Size(84, 57);
            this.btnkl.TabIndex = 18;
            this.btnkl.Text = "+/-";
            this.btnkl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(380, 439);
            this.Controls.Add(this.btnsamadengan);
            this.Controls.Add(this.btntitik);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnkl);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnkurang);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnbagi);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnkali);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.txthasil);
            this.Controls.Add(this.txtinput);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.TextBox txthasil;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnkali;
        private System.Windows.Forms.Button btnbagi;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnkurang;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnsamadengan;
        private System.Windows.Forms.Button btntitik;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnkl;
    }
}

