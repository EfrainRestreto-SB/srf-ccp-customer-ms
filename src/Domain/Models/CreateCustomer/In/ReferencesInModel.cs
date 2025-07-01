namespace Domain.Models.CreateCustomer.In;

public class ReferencesInModel
{
    public string? ReferenceName { get; set; }          // E01RNM
    public string? ReferenceType { get; set; }          // E01RTP
    public string? ReferencePhone { get; set; }         // E01RPH
    public string? ReferenceRelationship { get; set; }  // E01RRL
}
