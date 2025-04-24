using System.Reflection;

namespace WindowsÖğrenciDatabaseÖdevi
{
    public partial class StudentMenu : Form
    {
        public StudentMenu()
        {
            InitializeComponent();
        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {

        }

        private void StudentCheckButton_Click(object sender, EventArgs e)
        {
            
            var student = new Student
            {
                FirstName = StudentName_Box.Text,
                LastName = StudentLastName_Box.Text,
                Department = StudentClass_Box.Text
            };

            // Attribute'lara göre doğrulama yap
            bool isValid = true;
            string errorMessage = "";

            // Reflection ile Student property'lerini al
            foreach (var prop in typeof(Student).GetProperties())
            {
                // RequiredFieldAttribute var mı kontrol et
                var requiredAttr = prop.GetCustomAttribute<RequiredFieldAttribute>();
                if (requiredAttr != null)
                {
                    string value = prop.GetValue(student)?.ToString();

                    // Eğer değer boşsa hata mesajını ekle
                    if (!requiredAttr.IsValid(value))
                    {
                        isValid = false;
                        errorMessage += requiredAttr.ErrorMessage + "\n";

                        
                        if (prop.Name == "FirstName") StudentLastName_Box.BackColor = Color.LightPink;
                        else if (prop.Name == "LastName") StudentLastName_Box.BackColor = Color.LightPink;
                        else if (prop.Name == "Department") StudentClass_Box.BackColor = Color.LightPink;
                    }
                }
            }

            if (isValid)
            {
                MessageBox.Show("Doğrulama başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateStudent(Student student, out string errorMessage)
        {
            errorMessage = "";
            bool isValid = true;

            foreach (var prop in typeof(Student).GetProperties())
            {
                var attribute = prop.GetCustomAttribute<RequiredFieldAttribute>();
                if (attribute != null)
                {
                    string value = prop.GetValue(student)?.ToString();

                    if (string.IsNullOrWhiteSpace(value))
                    {
                        isValid = false;
                        errorMessage += $"- {attribute.ErrorMessage}\n";
                        HighlightTextBox(prop.Name);
                    }
                    else if (attribute.MinLength > 0 && value.Trim().Length < attribute.MinLength)
                    {
                        isValid = false;
                        errorMessage += $"- {attribute.FieldName} en az {attribute.MinLength} karakter olmalıdır!\n";
                        HighlightTextBox(prop.Name);
                    }
                }
            }

            return isValid;
        }


        private void HighlightTextBox(string propertyName)
        {
            switch (propertyName)
            {
                case "FirstName": StudentName_Box.BackColor = Color.LightPink; break;
                case "LastName": StudentLastName_Box.BackColor = Color.LightPink; break;
                case "Department": StudentClass_Box.BackColor = Color.LightPink; break;
            }
        }

        
        private void ResetTextBoxColors()
        {
            StudentName_Box.BackColor = SystemColors.Window;
            StudentLastName_Box.BackColor = SystemColors.Window;
            StudentClass_Box.BackColor = SystemColors.Window;
        }
    }
}
