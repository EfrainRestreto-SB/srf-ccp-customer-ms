using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2;
using Domain.Dtos.Customer.In;
using Domain.Interfaces.Dynamo.Config;
using Microsoft.Extensions.Logging;
using System.Globalization;
using Domain.Interfaces.Repositories;

namespace Persistence.Repositories;

public class AwsDynamoRepository(IAmazonDynamoDB amazonDynamoDB,
                                IDynamoConnectionConfig dynamoConnectionConfig,
                                ILogger<AwsDynamoRepository> logger)
: IAwsDynamoRepository
{
    private readonly IAmazonDynamoDB amazonDynamoDB = amazonDynamoDB;
    private readonly IDynamoConnectionConfig dynamoConnectionConfig = dynamoConnectionConfig;
    private readonly ILogger<AwsDynamoRepository> logger = logger;

    private const string PartitionKey = "id";
    private const string SortKey = "createdAt";

    public async Task InsertCreateCustomerAsync(CreateCustomerOutDto createCustomer)
    {
        try
        {
            Dictionary<string, AttributeValue> basicInformation = new()
            {
                { "firstName", new AttributeValue { S = createCustomer.BasicInformation.FirstName } },
                { "secondName", new AttributeValue { S = createCustomer.BasicInformation.SecondName ?? string.Empty } },
                { "firstLastName", new AttributeValue { S = createCustomer.BasicInformation.FirstLastName } },
                { "secondLastName", new AttributeValue { S = createCustomer.BasicInformation.SecondLastName ?? string.Empty } },
                { "documentType", new AttributeValue { S = createCustomer.BasicInformation.DocumentType } },
                { "documentNumber", new AttributeValue { S = createCustomer.BasicInformation.DocumentNumber } },
                { "expeditionPlace", new AttributeValue { S = createCustomer.BasicInformation.ExpeditionPlace } },
                { "expeditionDate", new AttributeValue { S = createCustomer.BasicInformation.ExpeditionDate } },
                { "countryCode", new AttributeValue { S = createCustomer.BasicInformation.CountryCode } },
                { "stateCode", new AttributeValue { S = createCustomer.BasicInformation.StateCode } },
                { "cityCode", new AttributeValue { S = createCustomer.BasicInformation.CityCode } },
                { "gender", new AttributeValue { S = createCustomer.BasicInformation.Gender } },
                { "maritalStatus", new AttributeValue { S = createCustomer.BasicInformation.MaritalStatus } },
                { "educationLevel", new AttributeValue { S = createCustomer.BasicInformation.EducationLevel } },
                { "profession", new AttributeValue { S = createCustomer.BasicInformation.Profession } },
                { "economicActivity", new AttributeValue { S = createCustomer.BasicInformation.EconomicActivity } },
                { "riskLevel", new AttributeValue { S = createCustomer.BasicInformation.RiskLevel } }
            };

            Dictionary<string, AttributeValue> identification = new()
            {
                { "idType", new AttributeValue { S = createCustomer.Identification.IdType } },
                { "idCountry", new AttributeValue { S = createCustomer.Identification.IdCountry } },
                { "idIssuePlace", new AttributeValue { S = createCustomer.Identification.IdIssuePlace } },
                { "nationalityCode", new AttributeValue { S = createCustomer.Identification.NationalityCode } },
                { "fiscalEmployeeId", new AttributeValue { S = createCustomer.Identification.FiscalEmployeeId } }
            };

            Dictionary<string, AttributeValue> birthInfo = new()
            {
                { "birthDate", new AttributeValue { S = createCustomer.BirthInfo.BirthDate } },
                { "birthPlace", new AttributeValue { S = createCustomer.BirthInfo.BirthPlace } },
                { "birthCountryCode", new AttributeValue { S = createCustomer.BirthInfo.BirthCountryCode } },
                { "birthStateCode", new AttributeValue { S = createCustomer.BirthInfo.BirthStateCode } },
                { "birthCityCode", new AttributeValue { S = createCustomer.BirthInfo.BirthCityCode } }
            };

            Dictionary<string, AttributeValue> contactInfo = new()
            {
                { "emailType", new AttributeValue { S = createCustomer.ContactInfo.EmailType } },
                { "email", new AttributeValue { S = createCustomer.ContactInfo.Email } },
                { "phoneType", new AttributeValue { S = createCustomer.ContactInfo.PhoneType } },
                { "mainPhone", new AttributeValue { S = createCustomer.ContactInfo.MainPhone } },
                { "phoneExtension", new AttributeValue { S = createCustomer.ContactInfo.PhoneExtension ?? string.Empty } },
                { "mobileNumber", new AttributeValue { S = createCustomer.ContactInfo.MobileNumber } },
                { "alternatePhoneNumber", new AttributeValue { S = createCustomer.ContactInfo.AlternatePhoneNumber ?? string.Empty } }
            };

            Dictionary<string, AttributeValue> address = new()
            {
                { "addressType", new AttributeValue { S = createCustomer.Address.AddressType } },
                { "addressLine1", new AttributeValue { S = createCustomer.Address.AddressLine1 } },
                { "addressLine2", new AttributeValue { S = createCustomer.Address.AddressLine2 ?? string.Empty } },
                { "countryCode", new AttributeValue { S = createCustomer.Address.CountryCode } },
                { "stateCode", new AttributeValue { S = createCustomer.Address.StateCode } },
                { "cityCode", new AttributeValue { S = createCustomer.Address.CityCode } },
                { "postalCode", new AttributeValue { S = createCustomer.Address.PostalCode } }
            };

            Dictionary<string, AttributeValue> financialInfo = new()
            {
                { "income", new AttributeValue { N = createCustomer.FinancialInfo.Income.ToString(CultureInfo.InvariantCulture) } },
                { "expenses", new AttributeValue { N = createCustomer.FinancialInfo.Expenses.ToString(CultureInfo.InvariantCulture) } },
                { "assets", new AttributeValue { N = createCustomer.FinancialInfo.Assets.ToString(CultureInfo.InvariantCulture) } },
                { "liabilities", new AttributeValue { N = createCustomer.FinancialInfo.Liabilities.ToString(CultureInfo.InvariantCulture) } },
                { "economicActivityCode", new AttributeValue { S = createCustomer.FinancialInfo.EconomicActivityCode } },
                { "incomeSource", new AttributeValue { S = createCustomer.FinancialInfo.IncomeSource } },
                { "foreignCurrencyIncome", new AttributeValue { S = createCustomer.FinancialInfo.ForeignCurrencyIncome ?? string.Empty } },
                { "foreignCurrencyExpenses", new AttributeValue { S = createCustomer.FinancialInfo.ForeignCurrencyExpenses ?? string.Empty } },
                { "hasOtherIncome", new AttributeValue { S = createCustomer.FinancialInfo.HasOtherIncome } },
                { "otherIncomeDescription", new AttributeValue { S = createCustomer.FinancialInfo.OtherIncomeDescription ?? string.Empty } }
            };

            Dictionary<string, AttributeValue> employmentInfo = new()
            {
                { "employmentType", new AttributeValue { S = createCustomer.EmploymentInfo.EmploymentType } },
                { "employmentDescription", new AttributeValue { S = createCustomer.EmploymentInfo.EmploymentDescription ?? string.Empty } },
                { "employmentCountryCode", new AttributeValue { S = createCustomer.EmploymentInfo.EmploymentCountryCode } },
                { "employmentStateCode", new AttributeValue { S = createCustomer.EmploymentInfo.EmploymentStateCode } },
                { "employmentCityCode", new AttributeValue { S = createCustomer.EmploymentInfo.EmploymentCityCode } },
                { "employmentStartDate", new AttributeValue { S = createCustomer.EmploymentInfo.EmploymentStartDate } },
                { "employmentEndDate", new AttributeValue { S = createCustomer.EmploymentInfo.EmploymentEndDate ?? string.Empty } }
            };

            Dictionary<string, AttributeValue> foreignCurrencyInfo = new()
            {
                { "foreignCurrencyType", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignCurrencyType } },
                { "foreignCurrencyDescription", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignCurrencyDescription ?? string.Empty } },
                { "foreignCurrencyCountryCode", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignCurrencyCountryCode } },
                { "foreignCurrencyStateCode", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignCurrencyStateCode } },
                { "foreignCurrencyCityCode", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignCurrencyCityCode } }
            };

            Dictionary<string, AttributeValue> bankingInfo = new()
            {
                { "bankingType", new AttributeValue { S = createCustomer.BankingInfo.BankingType } },
                { "bankingDescription", new AttributeValue { S = createCustomer.BankingInfo.BankingDescription ?? string.Empty } },
                { "bankingCountryCode", new AttributeValue { S = createCustomer.BankingInfo.BankingCountryCode } },
                { "bankingStateCode", new AttributeValue { S = createCustomer.BankingInfo.BankingStateCode } },
                { "bankingCityCode", new AttributeValue { S = createCustomer.BankingInfo.BankingCityCode } }
            };

            Dictionary<string, AttributeValue> interviewInfo = new()
            {
                { "officeDescription", new AttributeValue { S = createCustomer.InterviewInfo.OfficeDescription ?? string.Empty } },
                { "idTypeDescription", new AttributeValue { S = createCustomer.InterviewInfo.IdTypeDescription ?? string.Empty } },
                { "idCountryDescription", new AttributeValue { S = createCustomer.InterviewInfo.IdCountryDescription ?? string.Empty } },
                { "nationalityDescription", new AttributeValue { S = createCustomer.InterviewInfo.NationalityDescription ?? string.Empty } },
                { "channelDescription", new AttributeValue { S = createCustomer.InterviewInfo.ChannelDescription ?? string.Empty } },
                { "educationDescription", new AttributeValue { S = createCustomer.InterviewInfo.EducationDescription ?? string.Empty } },
                { "activityDescription", new AttributeValue { S = createCustomer.InterviewInfo.ActivityDescription ?? string.Empty } },
                { "riskDescription", new AttributeValue { S = createCustomer.InterviewInfo.RiskDescription ?? string.Empty } },
                { "sectorDescription", new AttributeValue { S = createCustomer.InterviewInfo.SectorDescription ?? string.Empty } },
                { "residenceCountryDescription", new AttributeValue { S = createCustomer.InterviewInfo.ResidenceCountryDescription ?? string.Empty } },
                { "commercialOfficerDescription", new AttributeValue { S = createCustomer.InterviewInfo.CommercialOfficerDescription ?? string.Empty } },
                { "secondaryOfficerDescription", new AttributeValue { S = createCustomer.InterviewInfo.SecondaryOfficerDescription ?? string.Empty } },
                { "entityDescription", new AttributeValue { S = createCustomer.InterviewInfo.EntityDescription ?? string.Empty } },
                { "businessTypeDescription", new AttributeValue { S = createCustomer.InterviewInfo.BusinessTypeDescription ?? string.Empty } },
                { "segmentDescription", new AttributeValue { S = createCustomer.InterviewInfo.SegmentDescription ?? string.Empty } },
                { "degreeDescription", new AttributeValue { S = createCustomer.InterviewInfo.DegreeDescription ?? string.Empty } },
                { "departmentDescription", new AttributeValue { S = createCustomer.InterviewInfo.DepartmentDescription ?? string.Empty } },
                { "positionDescription", new AttributeValue { S = createCustomer.InterviewInfo.PositionDescription ?? string.Empty } },
                { "contractDescription", new AttributeValue { S = createCustomer.InterviewInfo.ContractDescription ?? string.Empty } },
                { "transaction1Description", new AttributeValue { S = createCustomer.InterviewInfo.Transaction1Description ?? string.Empty } },
                { "nichoDescription", new AttributeValue { S = createCustomer.InterviewInfo.NichoDescription ?? string.Empty } }
            };

            Dictionary<string, AttributeValue> item = new()
            {
                { PartitionKey, new AttributeValue { S = createCustomer.Id } },
                { SortKey, new AttributeValue { S = DateTime.UtcNow.ToString("o") } },
                { "BasicInformation", new AttributeValue { M = basicInformation } },
                { "Identification", new AttributeValue { M = identification } },
                { "BirthInfo", new AttributeValue { M = birthInfo } },
                { "ContactInfo", new AttributeValue { M = contactInfo } },
                { "Address", new AttributeValue { M = address } },
                { "FinancialInfo", new AttributeValue { M = financialInfo } },
                { "EmploymentInfo", new AttributeValue { M = employmentInfo } },
                { "ForeignCurrencyInfo", new AttributeValue { M = foreignCurrencyInfo } },
                { "BankingInfo", new AttributeValue { M = bankingInfo } },
                { "InterviewInfo", new AttributeValue { M = interviewInfo } }
            };

            PutItemRequest request = new()
            {
                TableName = dynamoConnectionConfig.TableName(),
                Item = item
            };

            _ = await amazonDynamoDB.PutItemAsync(request);
            logger.LogInformation("Customer inserted successfully.");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error inserting customer into DynamoDB: {Inner}, {StackTrace}", ex.InnerException, ex.StackTrace);
            throw;
        }
    }
