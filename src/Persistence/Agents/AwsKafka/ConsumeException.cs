
namespace Persistence.Agents.AwsKafka
{
    [Serializable]
    internal class ConsumeException : Exception
    {
        public ConsumeException()
        {
        }

        public ConsumeException(string? message) : base(message)
        {
        }

        public ConsumeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}