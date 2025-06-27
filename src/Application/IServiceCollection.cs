namespace Application;

public interface IServiceCollection
{
    void AddAWSService<T>(AWSOptions awsOptions);
    void AddScoped<T1, T2>();
    void AddSingleton(AWSOptions awsOptions);
}
