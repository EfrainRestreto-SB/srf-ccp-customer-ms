namespace Domain.Entities.Customer;

public class BirthInfo
{
    public DateTime BirthDate { get; set; }
    public string BirthCity { get; set; } = default!;
    public string BirthCountry { get; set; } = default!;
}
