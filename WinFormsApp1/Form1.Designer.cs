﻿namespace WinFormsApp1
{
    partial class Form1 : Form  

    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 23);
            textBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(320, 162);
            button2.Name = "button2";
            button2.Size = new Size(24, 24);
            button2.TabIndex = 3;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(187, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(111, 23);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 130);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Zahl 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 171);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Zahl 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 212);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Ergebniss ";
            // 
            // button1
            // 
            button1.Location = new Point(360, 162);
            button1.Name = "button1";
            button1.Size = new Size(26, 24);
            button1.TabIndex = 8;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(320, 208);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 9;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(359, 208);
            button4.Name = "button4";
            button4.Size = new Size(27, 23);
            button4.TabIndex = 10;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(403, 162);
            button5.Name = "button5";
            button5.Size = new Size(27, 24);
            button5.TabIndex = 11;
            button5.Text = "%";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(403, 207);
            button6.Name = "button6";
            button6.Size = new Size(27, 24);
            button6.TabIndex = 12;
            button6.Text = "!";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button6_Click_1;
            // 
            // button7
            // 
            button7.Location = new Point(309, 289);
            button7.Name = "button7";
            button7.Size = new Size(174, 84);
            button7.TabIndex = 13;
            button7.Text = "Nicht Drücken";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button7_Click_1;
            // 
            // From1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 375);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "From1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
