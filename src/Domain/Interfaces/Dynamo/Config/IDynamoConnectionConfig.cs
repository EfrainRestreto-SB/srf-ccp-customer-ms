namespace Core.Interfaces.Configuration
{
    public interface IDynamoConnectionConfig
    {
        /// <summary>
        /// Región de AWS donde está alojada la tabla DynamoDB (ej: "us-east-1")
        /// </summary>
        string Region { get; }

        /// <summary>
        /// Nombre de la tabla DynamoDB
        /// </summary>
        string TableName { get; }

        /// <summary>
        /// Access key de AWS (si no usas roles o credenciales implícitas)
        /// </summary>
        string AccessKey { get; }

        /// <summary>
        /// Secret key de AWS (si no usas roles o credenciales implícitas)
        /// </summary>
        string SecretKey { get; }

        /// <summary>
        /// Endpoint personalizado de DynamoDB (útil para entornos locales como DynamoDB Local)
        /// </summary>
        string ServiceURL { get; }
    }
}
