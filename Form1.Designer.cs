namespace WinFormsApp1
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
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(505, 563);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(150, 47);
            button2.TabIndex = 24;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(812, 467);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 32);
            label6.TabIndex = 23;
            label6.Text = "Result";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(791, 465);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 32);
            label7.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 465);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 21;
            label5.Text = "Result is:";
            // 
            // button1
            // 
            button1.Location = new Point(150, 457);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(266, 47);
            button1.TabIndex = 20;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 350);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 32);
            label4.TabIndex = 19;
            label4.Text = "Third Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 265);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(193, 32);
            label3.TabIndex = 18;
            label3.Text = "Second Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 177);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 17;
            label2.Text = "First Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(396, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(360, 32);
            label1.TabIndex = 16;
            label1.Text = "Program #3:   YOUR NAME HERE";
            label1.Click += label1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(618, 343);
            textBox3.Margin = new Padding(4, 2, 4, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 39);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(615, 260);
            textBox2.Margin = new Padding(4, 2, 4, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 39);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(615, 175);
            textBox1.Margin = new Padding(4, 2, 4, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 39);
            textBox1.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(51, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 272);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(30, 47);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(132, 36);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Average";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(30, 120);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(152, 36);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Maximum";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(30, 192);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(149, 36);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Minimum";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 634);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label6;
        private Label label7;
        private Label label5;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}