using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsÖğrenciDatabaseÖdevi
{
    public class Student
    {
        [RequiredField("Ad en az 3 karakter olmalıdır!", FieldName = "Adı", MinLength = 3)]
        public string FirstName { get; set; }

        [RequiredField("Soyad en az 2 karakter olmalıdır!", FieldName = "Soyadı", MinLength = 2)]
        public string LastName { get; set; }

        [RequiredField("Bölüm bilgisi boş bırakılamaz!", FieldName = "Bölümü")]
        public string Department { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Department}";
        }
    }
}
