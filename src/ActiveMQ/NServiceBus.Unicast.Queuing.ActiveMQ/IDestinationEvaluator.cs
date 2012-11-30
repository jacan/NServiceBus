namespace NServiceBus.Unicast.Queuing.ActiveMQ
{
    using Apache.NMS;

    public interface IDestinationEvaluator
    {
        IDestination GetDestination(INetTxSession session, string destination, string prefix);
    }
}