namespace Utils.Constants
{
    public static class CustomerValidationConstants
    {
        // Campos comunes
        public const string DocumentType = "DocumentType";
        public const string DocumentNumber = "DocumentNumber";
        public const string FullName = "FullName";
        public const string Email = "Email";
        public const string Phone = "Phone";
        public const string Street = "Street";
        public const string City = "City";
        public const string ZipCode = "ZipCode";
        public const string Type = "Type";
        public const string Content = "Content";
        public const string Name = "Name";

        // Longitudes mínimas y máximas
        public const int MinDocumentNumberLength = 5;
        public const int MaxDocumentNumberLength = 20;
        public const int MinFullNameLength = 3;
        public const int MaxFullNameLength = 100;
        public const int MaxStreetLength = 100;
        public const int MaxContentLength = 250;
        public const int MaxZipCodeLength = 10;
        public const int MinPhoneLength = 7;
        public const int MaxPhoneLength = 15;

        // Regex
        public const string NumericRegex = "^[0-9]*$";

        // Mensajes
        public const string RequiredMessage = "The field '{0}' is required.";
        public const string InvalidEmailMessage = "The field '{0}' must be a valid email address.";
        public const string LengthBetweenMessage = "The field '{0}' must be between {1} and {2} characters.";
        public const string MaxLengthMessage = "The field '{0}' must not exceed {1} characters.";
        public const string NumericOnlyMessage = "The field '{0}' must contain only numbers.";
    }
}
