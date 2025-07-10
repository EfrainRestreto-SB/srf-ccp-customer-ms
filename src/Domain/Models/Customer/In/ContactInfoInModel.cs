namespace Domain.Dto.In
{
    public class ContactInfoDto
    {
        public required string EmailType { get; set; }
        public required string Email { get; set; }
        public required string PhoneType { get; set; }
        public required string mainPhone { get; set; }
        public required string PhoneExtension { get; set; }
    }
}
