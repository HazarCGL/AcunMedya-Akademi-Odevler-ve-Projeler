[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class RequiredFieldAttribute : Attribute
{
    public string ErrorMessage { get; set; }
    public string FieldName { get; set; }
    public int MinLength { get; set; } = 0; // Varsayılan değer 0 (minimum uzunluk zorunlu değil)

    public RequiredFieldAttribute(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public bool IsValid(string value)
    {
        // Boşluk kontrolü
        if (string.IsNullOrWhiteSpace(value))
            return false;

        // Minimum uzunluk kontrolü
        if (MinLength > 0 && value.Trim().Length < MinLength)
            return false;

        return true;
    }
}