namespace Ödeme_Sistemi_Ödevi
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            button3 = new Button();
            button2 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(23, 28);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 0;
            label1.Text = "Tutar :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(26, 103);
            label2.Name = "label2";
            label2.Size = new Size(187, 32);
            label2.TabIndex = 1;
            label2.Text = "Ödeme Yöntemi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(23, 390);
            label3.Name = "label3";
            label3.Size = new Size(190, 32);
            label3.TabIndex = 2;
            label3.Text = "Sipariş Durumu :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(248, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 168);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kart Bİlgileri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(11, 125);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(32, 23);
            textBox5.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 107);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 14;
            label8.Text = "CVV :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(11, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(55, 23);
            textBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 63);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 10;
            label6.Text = "SKT :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 23);
            textBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 19);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 8;
            label5.Text = "Kart No:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(313, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 168);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Banka Seçimi";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(162, 143);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 7;
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(110, 143);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 6;
            label10.Text = "Sonuç :";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(110, 114);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 5;
            label9.Text = "B Bankası";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 84);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 4;
            label7.Text = "A Bankası";
            // 
            // button3
            // 
            button3.Location = new Point(12, 110);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "BAŞVUR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 81);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "BAŞVUR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "B Bankası (%1.47)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(11, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(118, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "A Bankası (%1.89)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(624, 259);
            button1.Name = "button1";
            button1.Size = new Size(139, 67);
            button1.TabIndex = 5;
            button1.Text = "Ödemeyi Onayla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(219, 390);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ödeme Alma Sistemi By Muhammed Hazar Çağlayan";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Button button3;
        private Button button2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
