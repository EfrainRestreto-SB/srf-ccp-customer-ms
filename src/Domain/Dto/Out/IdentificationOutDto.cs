namespace Domain.Dto.Out
{
    public class IdentificationOutDto
    {
        public string DocumentType { get; set; }
        public string Identity { get; set; }
        public string ExpeditionDate { get; set; }
        public string ExpeditionCity { get; set; }
        public string ExpeditionDepartment { get; set; }
        public string ExpeditionCountry { get; set; }
        public string IdentificationCountry { get; set; }
        public string PlaceExpedition { get; set; }
    }
}
