using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Domain.Dto.In;
using Domain.Dtos.Customer.In;
using Domain.Interfaces.Dynamo.Config;
using Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using System.Drawing;
using System.Globalization;

namespace Persistence.Repositories;

public class AwsDynamoRepository(IAmazonDynamoDB amazonDynamoDB,
                                IDynamoConnectionConfig dynamoConnectionConfig,
                                ILogger<AwsDynamoRepository> logger,
                                object co)
: IAwsDynamoRepository
{
    private readonly IAmazonDynamoDB amazonDynamoDB = amazonDynamoDB;
    private readonly IDynamoConnectionConfig dynamoConnectionConfig = dynamoConnectionConfig;
    private readonly ILogger<AwsDynamoRepository> logger = logger;
    private readonly object co;
    private Dictionary<string, AttributeValue> item;
    private const string PartitionKey = "id";
    private const string SortKey = "createdAt";

    public async Task InsertCreateCustomerAsync(CreateCustomerOutDto createCustomer)
    {
        try
        {
            Dictionary<string, AttributeValue> basicInformation = new()
            {
                { "firstName", new AttributeValue { S = createCustomer.BasicInformation.FirstName.ToString() } },
    { "secondName", new AttributeValue { S = createCustomer.BasicInformation.SecondName.ToString() } },
    { "firstLastName", new AttributeValue { S = createCustomer.BasicInformation.FirstLastName.ToString() } },
    { "secondLastName", new AttributeValue { S = createCustomer.BasicInformation.SecondLastName.ToString() } },
    { "legalName", new AttributeValue { S = createCustomer.BasicInformation.LegalName.ToString() } },
    { "gender", new AttributeValue { S = createCustomer.BasicInformation.Gender.ToString() } },
    { "clientType", new AttributeValue { S = createCustomer.BasicInformation.ClientType.ToString() } },
    { "maritalStatus", new AttributeValue { S = createCustomer.BasicInformation.MaritalStatus.ToString() } },
    { "language", new AttributeValue { S = createCustomer.BasicInformation.Language.ToString() } },
    { "consultationLevel", new AttributeValue { N = createCustomer.BasicInformation.ConsultationLevel.ToString() } },
    { "riskLevelCode", new AttributeValue { S = createCustomer.BasicInformation.RiskLevelCode.ToString() } },
    { "economicSector", new AttributeValue { S = createCustomer.BasicInformation.EconomicSector.ToString() } },
    { "economicActivity", new AttributeValue { S = createCustomer.BasicInformation.EconomicActivity.ToString() } },
    { "stratum", new AttributeValue { S = createCustomer.BasicInformation.Stratum.ToString() } },
    { "educationLevel", new AttributeValue { S = createCustomer.BasicInformation.EducationLevel.ToString() } },
    { "nichoCode", new AttributeValue { S = createCustomer.BasicInformation.NichoCode.ToString() } },
    { "isPEP", new AttributeValue { S = createCustomer.BasicInformation.IsPEP.ToString() } },
    { "managesPublicMoney", new AttributeValue { S = createCustomer.BasicInformation.ManagesPublicMoney.ToString() } },
    { "hasPublicRecognition", new AttributeValue { S = createCustomer.BasicInformation.HasPublicRecognition.ToString() } },
    { "status", new AttributeValue { S = createCustomer.BasicInformation.Status.ToString() } },
    { "hasTaxExemptions", new AttributeValue { S = createCustomer.BasicInformation.HasTaxExemptions.ToString() } },
    { "isTaxWithHolder", new AttributeValue { S = createCustomer.BasicInformation.IsTaxWithHolder.ToString() } },
    { "isBigTaxpayer", new AttributeValue { S = createCustomer.BasicInformation.IsBigTaxpayer.ToString() } },
    { "taxpayerType", new AttributeValue { S = createCustomer.BasicInformation.TaxpayerType.ToString() } },
    { "specialTaxConditions", new AttributeValue { S = createCustomer.BasicInformation.SpecialTaxConditions.ToString() } },


            };

            Dictionary<string, AttributeValue> Identification = new()
{
    { "idNumber", new AttributeValue { S = createCustomer.Identification.IdNumber.ToString() } },
    { "idType", new AttributeValue { S = createCustomer.Identification.IdType.ToString() } },
    { "idCountry", new AttributeValue { S = createCustomer.Identification.IdCountry.ToString() } },
    { "idIssuePlace", new AttributeValue { S = createCustomer.Identification.IdIssuePlace.ToString() } },
    { "idIssueMonth", new AttributeValue { N = createCustomer.Identification.IdIssueMonth.ToString() } },
    { "idIssueDay", new AttributeValue { N = createCustomer.Identification.IdIssueDay.ToString() } },
    { "idIssueYear", new AttributeValue { N = createCustomer.Identification.IdIssueYear.ToString() } },
    { "nationalityCode", new AttributeValue { S = createCustomer.Identification.NationalityCode.ToString() } },
    { "fiscalEmployeeId", new AttributeValue { S = createCustomer.Identification.FiscalEmployeeId.ToString() } },
};

            Dictionary<string, AttributeValue> birthInfo = new()
            {
                { "birthMonth", new AttributeValue { S = createCustomer.birthInfo.BirthMonth.ToString() } },
                { "birthDay", new AttributeValue { S = createCustomer.birthInfo.BirthDay.ToString() } },
                { "birthYear", new AttributeValue { S = createCustomer.birthInfo.BirthYear.ToString() } },
                { "birthCountry", new AttributeValue { S = createCustomer.birthInfo.BirthCountry.ToString() } },
                { "birthDepartment", new AttributeValue { S = createCustomer.birthInfo.BirthDepartment.ToString() } },
                { "birthCity", new AttributeValue { S = createCustomer.birthInfo.BirthCity.ToString() } },



            };

            Dictionary<string, AttributeValue> contactInfo = new()
            {
                { "emailType", new AttributeValue { S = createCustomer.ContactInfo.EmailType .ToString()} },
                { "email", new AttributeValue { S = createCustomer.ContactInfo.Email .ToString()} },
                { "phoneType", new AttributeValue { S = createCustomer.ContactInfo.PhoneType .ToString() } },
                { "mainPhone", new AttributeValue { S = createCustomer.ContactInfo.MainPhone .ToString  ()} },
                { "phoneExtension", new AttributeValue { S = createCustomer.ContactInfo.PhoneExtension .ToString() } },

            };

            Dictionary<string, AttributeValue> address = new()
            {
                { "addressLine1", new AttributeValue { S = createCustomer.AddressInfo.AddressLine1.ToString() } },
                 { "addressLine2", new AttributeValue { S = createCustomer.AddressInfo.AddressLine2.ToString() } },
                    { "addressLine3", new AttributeValue { S = createCustomer.AddressInfo.AddressLine3.ToString() } },
                   { "city", new AttributeValue { S = createCustomer.AddressInfo.City.ToString() } },
                  { "cityCode", new AttributeValue { S = createCustomer.AddressInfo.CityCode.ToString() } },
                { "country", new AttributeValue { S = createCustomer.AddressInfo.Country.ToString() } },
                 { "postalCode", new AttributeValue { S = createCustomer.AddressInfo.PostalCode.ToString() } },
                    { "residenceCountry", new AttributeValue { S = createCustomer.AddressInfo.ResidenceCountry.ToString() } },
                 { "currentResidenceYears", new AttributeValue { N = createCustomer.AddressInfo.CurrentResidenceYears.ToString() } },
                { "currentResidenceMonths", new AttributeValue { N = createCustomer.AddressInfo.CurrentResidenceMonths.ToString() } },
                { "housingType", new AttributeValue { S = createCustomer.AddressInfo.HousingType.ToString() } }
            };

            Dictionary<string, AttributeValue> financialInfo = new()
            {
                { "monthlyIncome", new AttributeValue { N = createCustomer.FinancialInfo.MonthlyIncome.ToString() } },
    { "otherIncome", new AttributeValue { N = createCustomer.FinancialInfo.OtherIncome.ToString() } },
    { "familyExpenses", new AttributeValue { N = createCustomer.FinancialInfo.FamilyExpenses.ToString() } },
    { "totalLiabilities", new AttributeValue { N = createCustomer.FinancialInfo.TotalLiabilities.ToString() } },
    { "otherAssets", new AttributeValue { N = createCustomer.FinancialInfo.OtherAssets.ToString() } },
    { "realStateAssets", new AttributeValue { N = createCustomer.FinancialInfo.RealStateAssets.ToString() } },
    { "totalAssets", new AttributeValue { N = createCustomer.FinancialInfo.TotalAssets.ToString() } },
    { "totalIncome", new AttributeValue { N = createCustomer.FinancialInfo.TotalIncome.ToString() } },
    { "totalExpenses", new AttributeValue { N = createCustomer.FinancialInfo.TotalExpenses.ToString() } },
    { "fundsOriginDescription1", new AttributeValue { S = createCustomer.FinancialInfo.FundsOriginDescription1.ToString() } },
    { "fundsOriginDescription2", new AttributeValue { S = createCustomer.FinancialInfo.FundsOriginDescription2.ToString() } },
    { "fundsOriginDescription3", new AttributeValue { S = createCustomer.FinancialInfo.FundsOriginDescription3.ToString() } }
            };

            Dictionary<string, AttributeValue> employmentInfo = new()
            {
    { "employmentType", new AttributeValue { S = createCustomer.EmploymentInfo.EmploymentType.ToString()} },
    { "companyName", new AttributeValue { S = createCustomer.EmploymentInfo.CompanyName.ToString() } },
    { "companyAddress", new AttributeValue { S = createCustomer.EmploymentInfo.CompanyAddress .ToString()} },
    { "jobPosition", new AttributeValue { S = createCustomer.EmploymentInfo.JobPosition .ToString()} },
    { "previousCompany", new AttributeValue { S = createCustomer.EmploymentInfo.PreviousCompany.ToString() } },

    { "employmentStartDay", new AttributeValue { N = createCustomer.EmploymentInfo.EmploymentStartDay.ToString() } },
    { "employmentStartMonth", new AttributeValue { N = createCustomer.EmploymentInfo.EmploymentStartMonth.ToString() } },
    { "employmentStartYear", new AttributeValue { N = createCustomer.EmploymentInfo.EmploymentStartYear.ToString() } },

    { "companyCityCode", new AttributeValue { S = createCustomer.EmploymentInfo.CompanyCityCode.ToString() } },
    { "companyCountry", new AttributeValue { S = createCustomer.EmploymentInfo.CompanyCountry .ToString() } },
    { "contractType", new AttributeValue { S = createCustomer.EmploymentInfo.ContractType.ToString() } },
    { "departmentCode", new AttributeValue { S = createCustomer.EmploymentInfo.DepartmentCode.ToString() } },

    { "workPhone", new AttributeValue { S = createCustomer.EmploymentInfo.WorkPhone.ToString()} },
    { "workExtension", new AttributeValue { S = createCustomer.EmploymentInfo.WorkExtension.ToString() } },

    { "previousJobYears", new AttributeValue { N = createCustomer.EmploymentInfo.PreviousJobYears.ToString() } },
    { "previousJobMonths", new AttributeValue { N = createCustomer.EmploymentInfo.PreviousJobMonths.ToString() } },

    { "employeesCount", new AttributeValue { N = createCustomer.EmploymentInfo.EmployeesCount.ToString() } },
    { "occupationCode", new AttributeValue { S = createCustomer.EmploymentInfo.OccupationCode.ToString() } },
    { "dependentsCount", new AttributeValue { N = createCustomer.EmploymentInfo.DependentsCount.ToString() } }
            };

            Dictionary<string, AttributeValue> foreignCurrencyInfo = new()
{
    { "foreignTransactions", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignTransactions?.ToString() } },
    { "foreignProducts", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignProducts?.ToString() } },
    { "transaction1Amount", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.Transaction1Amount.ToString() } },
    { "transaction1Type", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.Transaction1Type?.ToString() } },
    { "transaction2Amount", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.Transaction2Amount.ToString() } },
    { "transaction2Type", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.Transaction2Type?.ToString() } },
    { "transaction3Amount", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.Transaction3Amount.ToString() } },
    { "transaction3Type", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.Transaction3Type?.ToString() } },
    { "foreignBank1Name", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignBank1Name?.ToString() } },
    { "foreignBank1Product", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignBank1Product?.ToString() } },
    { "foreignBank1Currency", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignBank1Currency?.ToString() } },
    { "foreignBank1Account", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignBank1Account?.ToString() } },
    { "foreignBank1Balance", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignBank1Balance.ToString() } },
    { "foreignBank1Country", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignBank1Country?.ToString() } },
    { "foreignBank1City", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.ForeignBank1City?.ToString() } },
    { "isForexMarketIntermediary", new AttributeValue { S = createCustomer.ForeignCurrencyInfo.IsForexMarketIntermediary?.ToString() } }
};


            Dictionary<string, AttributeValue> bankingInfo = new()
            {
                { "affiliationMonth", new AttributeValue { N = createCustomer.BankingInfo.AffiliationMonth.ToString() } },
    { "affiliationDay", new AttributeValue { N = createCustomer.BankingInfo.AffiliationDay.ToString() } },
    { "affiliationYear", new AttributeValue { N = createCustomer.BankingInfo.AffiliationYear.ToString() } },
    { "affiliationOfficeCode", new AttributeValue { S = createCustomer.BankingInfo.AffiliationOfficeCode } },
    { "affiliationChannel", new AttributeValue { S = createCustomer.BankingInfo.AffiliationChannel } },
    { "statementDelivery", new AttributeValue { S = createCustomer.BankingInfo.StatementDelivery } },
    { "electronicOperations", new AttributeValue { S = createCustomer.BankingInfo.ElectronicOperations } },
    { "commercialOfficerCode", new AttributeValue { S = createCustomer.BankingInfo.CommercialOfficerCode } },
    { "secondaryOfficerCode", new AttributeValue { S = createCustomer.BankingInfo.SecondaryOfficerCode } },
    { "entityToAffiliateCode", new AttributeValue { S = createCustomer.BankingInfo.EntityToAffiliateCode } },
    { "superEntityType", new AttributeValue { S = createCustomer.BankingInfo.SuperEntityType } },
    { "legalNature", new AttributeValue { S = createCustomer.BankingInfo.LegalNature } },
    { "businessType", new AttributeValue { S = createCustomer.BankingInfo.BusinessType } },
    { "segmentCode", new AttributeValue { S = createCustomer.BankingInfo.SegmentCode } },
    { "superEntityCode", new AttributeValue { S = createCustomer.BankingInfo.SuperEntityCode } },
    { "addressTypeCode", new AttributeValue { S = createCustomer.BankingInfo.AddressTypeCode } },
    { "undergraduateDegree", new AttributeValue { S = createCustomer.BankingInfo.UndergraduateDegree } },
    { "interviewType", new AttributeValue { S = createCustomer.BankingInfo.InterviewType } },
    { "bankRelation", new AttributeValue { S = createCustomer.BankingInfo.BankRelation } },
    { "serviceType", new AttributeValue { S = createCustomer.BankingInfo.ServiceType } },
    { "riskPercentage", new AttributeValue { N = createCustomer.BankingInfo.RiskPercentage.ToString() } }
            };

            Dictionary<string, AttributeValue> interviewInfo = new()
{
    { "interviewerName", new AttributeValue { S = createCustomer.InterviewInfo.InterviewerName?.ToString() } },
    { "interviewerId", new AttributeValue { S = createCustomer.InterviewInfo.InterviewerId?.ToString() } },
    { "interviewerIdType", new AttributeValue { S = createCustomer.InterviewInfo.InterviewerIdType?.ToString() } },
    { "interviewerIdCountry", new AttributeValue { S = createCustomer.InterviewInfo.InterviewerIdCountry?.ToString() } },
    { "interviewMonth", new AttributeValue { S = createCustomer.InterviewInfo.InterviewMonth.ToString() } },
    { "interviewDay", new AttributeValue { S = createCustomer.InterviewInfo.InterviewDay.ToString() } },
    { "interviewYear", new AttributeValue { S = createCustomer.InterviewInfo.InterviewYear.ToString() } },
    { "customerKnowledgeReport", new AttributeValue { S = createCustomer.InterviewInfo.CustomerKnowledgeReport?.ToString() } },
    { "interviewResult", new AttributeValue { S = createCustomer.InterviewInfo.InterviewResult?.ToString() } },
    { "masterClientCode", new AttributeValue { S = createCustomer.InterviewInfo.MasterClientCode.ToString() } }
};



            Dictionary<string, AttributeValue> InterviewInfo = new()
{
    { "interviewerName", new AttributeValue { S = createCustomer.InterviewInfo.InterviewerName.ToString() } },
    { "interviewerId", new AttributeValue { S = createCustomer.InterviewInfo.InterviewerId.ToString() } },
    { "interviewerIdType", new AttributeValue { S = createCustomer.InterviewInfo.InterviewerIdType.ToString() } },
    { "interviewerIdCountry", new AttributeValue { S = createCustomer.InterviewInfo.InterviewerIdCountry.ToString() } },
    { "interviewMonth", new AttributeValue { S = createCustomer.InterviewInfo.InterviewMonth.ToString() } },
    { "interviewDay", new AttributeValue { S = createCustomer.InterviewInfo.InterviewDay.ToString() } },
    { "interviewYear", new AttributeValue { S = createCustomer.InterviewInfo.InterviewYear.ToString() } },
    { "customerKnowledgeReport", new AttributeValue { S = createCustomer.InterviewInfo.CustomerKnowledgeReport.ToString() } },
    { "interviewResult", new AttributeValue { S = createCustomer.InterviewInfo.InterviewResult.ToString() } },
    { "masterClientCode", new AttributeValue { S = createCustomer.InterviewInfo.MasterClientCode.ToString() } }
};



            Dictionary<string, AttributeValue> references = new()
            {
        { "referenceType", new AttributeValue { S = createCustomer.References.ReferenceType.ToString() } },
        { "companyName", new AttributeValue { S = createCustomer.References.CompanyName.ToString() } },
        { "contactName", new AttributeValue { S = createCustomer.References.ContactName.ToString() } },
        { "firstLastName", new AttributeValue { S = createCustomer.References.FirstLastName.ToString() } },
        { "secondLastName", new AttributeValue { S = createCustomer.References.SecondLastName.ToString() } },
        { "countryCode", new AttributeValue { S = createCustomer.References.CountryCode.ToString() } },
        { "departmentCode", new AttributeValue { S = createCustomer.References.DepartmentCode.ToString() } },
        { "cityCode", new AttributeValue { S = createCustomer.References.CityCode.ToString() } },
        { "landlinePhone", new AttributeValue { S = createCustomer.References.LandlinePhone.ToString() } },
        { "mobilePhone", new AttributeValue { S = createCustomer.References.MobilePhone.ToString() } },
        { "phoneExtension", new AttributeValue { S = createCustomer.References.PhoneExtension.ToString() } },
        { "relationship", new AttributeValue { S = createCustomer.References.Relationship.ToString() } },
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

  
    

    public async Task<CreateCustomerOutDto?> GetCustomerListByIdAsync(string id)
    {
        try
        {
            QueryRequest queryRequest = new()
            {
                TableName = dynamoConnectionConfig.TableName(),
                KeyConditionExpression = "id = :id",
                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
                {
                    { ":id", new AttributeValue { S = id } }
                }
            };

            QueryResponse response = await amazonDynamoDB.QueryAsync(queryRequest);

            if (response.Items.Count == 0)
            {
                logger.LogInformation("No customer found with id: {Id}", id);
                return null;
            }

            return ConvertToCustomerDto(response.Items.First());
        }
        catch (Exception ex)
        {
            HandleException(ex);
            throw;
        }
    }

    private CreateCustomerOutDto? ConvertToCustomerDto(Dictionary<string, AttributeValue> dictionary)
    {
        throw new NotImplementedException();
    }

    private BasicInformationOutDto MapBasicInformation(Dictionary<string, AttributeValue> map)
    {
        return new BasicInformationOutDto
        {
            FirstName = GetStringValue(item, "firstName"),
            SecondName = GetStringValue(item, "secondName"),
            FirstLastName = GetStringValue(item, "firstLastName"),
            SecondLastName = GetStringValue(item, "secondLastName"),
            LegalName = GetStringValue(item, "legalName"),
            Gender = GetStringValue(item, "gender"),
            ClientType = GetStringValue(item, "clientType"),
            MaritalStatus = GetStringValue(item, "maritalStatus"),
            Language = GetStringValue(item, "language"),
            ConsultationLevel = GetIntValue(item, "consultationLevel"),
            RiskLevelCode = GetStringValue(item, "riskLevelCode"),
            EconomicSector = GetStringValue(item, "economicSector"),
            EconomicActivity = GetStringValue(item, "economicActivity"),
            Stratum = GetStringValue(item, "stratum"),
            EducationLevel = GetStringValue(item, "educationLevel"),
            NichoCode = GetStringValue(item, "nichoCode"),
            IsPEP = GetStringValue(item, "isPEP"),
            ManagesPublicMoney = GetStringValue(item, "managesPublicMoney"),
            HasPublicRecognition = GetStringValue(item, "hasPublicRecognition"),
            Status = GetStringValue(item, "status"),
            HasTaxExemptions = GetStringValue(item, "hasTaxExemptions"),
            IsTaxWithHolder = GetStringValue(item, "isTaxWithHolder"),
            IsBigTaxpayer = GetStringValue(item, "isBigTaxpayer"),
            TaxpayerType = GetStringValue(item, "taxpayerType"),
            SpecialTaxConditions = GetStringValue(item, "specialTaxConditions")
        };
    }



    private static int GetIntValue(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? value) && int.TryParse(value?.N, out int result) ? result : 0;
    }

    private static long? GetLongValue(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? value) && long.TryParse(value?.N, out long result) ? result : null;
    }
    private static decimal GetDecimalValue(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? value) && decimal.TryParse(value?.N, out decimal result) ? result : 0m;
    }

    private static double GetDoubleValue(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? value) && double.TryParse(value?.N, out double result) ? result : 0;
    }

    private static string? GetStringValue(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? value) ? value?.S : null;
    }

    private void HandleException(Exception ex)
    {
        if (!ex.Data.Contains("Logged"))
        {
            logger.LogError(ex, "Error processing customer data");
            ex.Data["Logged"] = true;
        }
    }

    public Task<List<CreateCustomerOutDto>> GetCustomerList()
    {
        throw new NotImplementedException();
    }
}