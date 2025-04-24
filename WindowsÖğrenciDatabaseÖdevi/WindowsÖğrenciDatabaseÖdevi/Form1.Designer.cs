namespace WindowsÖğrenciDatabaseÖdevi
{
    partial class StudentMenu
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
            StudentName = new Label();
            StudentName_Box = new TextBox();
            StudentLastName = new Label();
            StudentLastName_Box = new TextBox();
            StudentClass = new Label();
            StudentClass_Box = new TextBox();
            StudentCheckButton = new Button();
            StudentOut = new Label();
            SuspendLayout();
            // 
            // StudentName
            // 
            StudentName.AutoSize = true;
            StudentName.Location = new Point(12, 25);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(70, 15);
            StudentName.TabIndex = 0;
            StudentName.Text = "Öğrenci Adı";
            // 
            // StudentName_Box
            // 
            StudentName_Box.Location = new Point(12, 43);
            StudentName_Box.Name = "StudentName_Box";
            StudentName_Box.Size = new Size(145, 23);
            StudentName_Box.TabIndex = 1;
            // 
            // StudentLastName
            // 
            StudentLastName.AutoSize = true;
            StudentLastName.Location = new Point(12, 78);
            StudentLastName.Name = "StudentLastName";
            StudentLastName.Size = new Size(87, 15);
            StudentLastName.TabIndex = 2;
            StudentLastName.Text = "Öğrenci Soyadı";
            // 
            // StudentLastName_Box
            // 
            StudentLastName_Box.Location = new Point(12, 96);
            StudentLastName_Box.Name = "StudentLastName_Box";
            StudentLastName_Box.Size = new Size(145, 23);
            StudentLastName_Box.TabIndex = 3;
            // 
            // StudentClass
            // 
            StudentClass.AutoSize = true;
            StudentClass.Location = new Point(12, 133);
            StudentClass.Name = "StudentClass";
            StudentClass.Size = new Size(94, 15);
            StudentClass.TabIndex = 4;
            StudentClass.Text = "Öğrenci Bölümü";
            // 
            // StudentClass_Box
            // 
            StudentClass_Box.Location = new Point(12, 160);
            StudentClass_Box.Name = "StudentClass_Box";
            StudentClass_Box.Size = new Size(145, 23);
            StudentClass_Box.TabIndex = 5;
            // 
            // StudentCheckButton
            // 
            StudentCheckButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StudentCheckButton.Location = new Point(252, 42);
            StudentCheckButton.Name = "StudentCheckButton";
            StudentCheckButton.Size = new Size(208, 106);
            StudentCheckButton.TabIndex = 6;
            StudentCheckButton.Text = "BİLGİLERİ DOĞRULA";
            StudentCheckButton.UseVisualStyleBackColor = true;
            StudentCheckButton.Click += StudentCheckButton_Click;
            // 
            // StudentOut
            // 
            StudentOut.AutoSize = true;
            StudentOut.Location = new Point(82, 246);
            StudentOut.Name = "StudentOut";
            StudentOut.Size = new Size(0, 15);
            StudentOut.TabIndex = 7;
            // 
            // StudentMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StudentOut);
            Controls.Add(StudentCheckButton);
            Controls.Add(StudentClass_Box);
            Controls.Add(StudentClass);
            Controls.Add(StudentLastName_Box);
            Controls.Add(StudentLastName);
            Controls.Add(StudentName_Box);
            Controls.Add(StudentName);
            Name = "StudentMenu";
            Text = "Öğrenci Bilgi İşlemleri Sistemi";
            Load += StudentMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentName;
        private TextBox StudentName_Box;
        private Label StudentLastName;
        private TextBox StudentLastName_Box;
        private Label StudentClass;
        private TextBox StudentClass_Box;
        private Button StudentCheckButton;
        private Label StudentOut;
    }
}
