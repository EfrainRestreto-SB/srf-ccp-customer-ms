namespace Persistence.Agents.AwsKafka
{
    internal interface IConsumer<TKey, TValue>
    {
        object Name { get; }

        void Subscribe(string v);
    }
}