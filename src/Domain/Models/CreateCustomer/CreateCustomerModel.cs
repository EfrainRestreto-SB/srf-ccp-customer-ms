using Domain.Models.CreateCustomer.In;
using System.Text.Json.Serialization;

namespace Domain.Models.Customer.In;

public class CreateCustomerInModel
{
    [JsonPropertyName("documentType")]
    public string? DocumentType { get; set; }

    [JsonPropertyName("documentNumber")]
    public string? DocumentNumber { get; set; }

    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }

    [JsonPropertyName("secondName")]
    public string? SecondName { get; set; }

    [JsonPropertyName("firstLastName")]
    public string? FirstLastName { get; set; }

    [JsonPropertyName("secondLastName")]
    public string? SecondLastName { get; set; }

    [JsonPropertyName("expeditionDate")]
    public string? ExpeditionDate { get; set; }

    [JsonPropertyName("expeditionPlace")]
    public string? ExpeditionPlace { get; set; }

    [JsonPropertyName("birthDate")]
    public string? BirthDate { get; set; }

    [JsonPropertyName("birthPlace")]
    public string? BirthPlace { get; set; }

    [JsonPropertyName("gender")]
    public string? Gender { get; set; }

    [JsonPropertyName("maritalStatus")]
    public string? MaritalStatus { get; set; }

    [JsonPropertyName("levelEducation")]
    public string? LevelEducation { get; set; }

    [JsonPropertyName("profession")]
    public string? Profession { get; set; }

    [JsonPropertyName("address")]
    public AddressInModel? Address { get; set; }

    [JsonPropertyName("contactInfo")]
    public ContactInfoInModel? ContactInfo { get; set; }

    [JsonPropertyName("descriptions")]
    public DescriptionsInModel? Descriptions { get; set; }

    [JsonPropertyName("reference")]
    public ReferenceInModel? Reference { get; set; }
}

public class AddressInModel
{
}

public class ReferenceInModel
{
}