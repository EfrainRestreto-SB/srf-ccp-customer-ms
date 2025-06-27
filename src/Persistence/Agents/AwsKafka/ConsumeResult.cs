namespace Persistence.Agents.AwsKafka
{
    internal class ConsumeResult<TKey, TValue>
    {
        public object Message { get; internal set; }
        public object Topic { get; internal set; }
        public object Partition { get; internal set; }
        public object Offset { get; internal set; }
    }
}