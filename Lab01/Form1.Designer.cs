﻿namespace Lab01
{
    partial class Form1
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
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(100, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 45);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(500, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 45);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(300, 300);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 45);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 40);
            label1.Name = "label1";
            label1.Size = new Size(105, 46);
            label1.TabIndex = 3;
            label1.Text = "num 1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(500, 40);
            label2.Name = "label2";
            label2.Size = new Size(110, 46);
            label2.TabIndex = 4;
            label2.Text = "num 2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(300, 240);
            label3.Name = "label3";
            label3.Size = new Size(86, 46);
            label3.TabIndex = 5;
            label3.Text = "Sum";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(300, 180);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = SystemColors.WindowText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
