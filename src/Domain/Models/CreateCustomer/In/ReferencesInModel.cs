namespace Domain.Models.CreateCustomer.In;

public class ReferencesInModel
{
    public string? ReferenceName { get; set; }
    public string? ReferenceType { get; set; }
    public string? ReferencePhone { get; set; }
    public string? ReferenceRelationship { get; set; }

    // Add missing property to fix CS1061 error  
    public string? Relacion { get; set; }
    public object Nombre { get; set; }
}
