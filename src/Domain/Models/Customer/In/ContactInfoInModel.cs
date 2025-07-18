namespace Domain.Models.Customer
{
    public class ContactInfoInModel
    {
        public string EmailType { get; set; }        // E01IAT
        public string Email { get; set; }            // E01IAD
        public string PhoneType { get; set; }        // E01PHT
        public string MainPhone { get; set; }        // E01PHO
        public string PhoneExtension { get; set; }   // E01PHX
    }
}
