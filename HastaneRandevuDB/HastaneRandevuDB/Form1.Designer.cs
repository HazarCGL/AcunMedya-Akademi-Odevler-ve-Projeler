namespace HastaneRandevuDB
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
            cbBrans = new ComboBox();
            cbDoktor = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label5 = new Label();
            dtTarih = new DateTimePicker();
            cbSaat = new ComboBox();
            label6 = new Label();
            btnRandevu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 28);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Branş Seçimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 84);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Doktor Seçimi";
            // 
            // cbBrans
            // 
            cbBrans.FormattingEnabled = true;
            cbBrans.Location = new Point(35, 46);
            cbBrans.Name = "cbBrans";
            cbBrans.Size = new Size(110, 23);
            cbBrans.TabIndex = 2;
            cbBrans.SelectedIndexChanged += cbBrans_SelectedIndexChanged;
            // 
            // cbDoktor
            // 
            cbDoktor.FormattingEnabled = true;
            cbDoktor.Location = new Point(35, 102);
            cbDoktor.Name = "cbDoktor";
            cbDoktor.Size = new Size(154, 23);
            cbDoktor.TabIndex = 3;
            cbDoktor.SelectedIndexChanged += cbDoktor_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 137);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Hasta Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 195);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 5;
            label4.Text = "Hasta Soyadı";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(35, 158);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(162, 23);
            txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(35, 213);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(162, 23);
            txtSoyad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 263);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 8;
            label5.Text = "Randevu Tarihi Seçimi";
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(35, 281);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(200, 23);
            dtTarih.TabIndex = 9;
            // 
            // cbSaat
            // 
            cbSaat.FormattingEnabled = true;
            cbSaat.Location = new Point(261, 281);
            cbSaat.Name = "cbSaat";
            cbSaat.Size = new Size(119, 23);
            cbSaat.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(261, 263);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 11;
            label6.Text = "Randevu Saati Seçimi";
            // 
            // btnRandevu
            // 
            btnRandevu.Font = new Font("Segoe UI", 15F);
            btnRandevu.Location = new Point(83, 320);
            btnRandevu.Name = "btnRandevu";
            btnRandevu.Size = new Size(217, 118);
            btnRandevu.TabIndex = 12;
            btnRandevu.Text = "Randevu Oluştur";
            btnRandevu.UseVisualStyleBackColor = true;
            btnRandevu.Click += btnRandevu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 450);
            Controls.Add(btnRandevu);
            Controls.Add(label6);
            Controls.Add(cbSaat);
            Controls.Add(dtTarih);
            Controls.Add(label5);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbDoktor);
            Controls.Add(cbBrans);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbBrans;
        private ComboBox cbDoktor;
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label5;
        private DateTimePicker dtTarih;
        private ComboBox cbSaat;
        private Label label6;
        private Button btnRandevu;
    }
}
