namespace DelegatesEventsLambdas.EventsPubSub
{
    class Subscriber
    {
        // Subscribe to the event
        internal void HandleFlagValueChanged(int value)
        {
            Console.WriteLine($"Flag value changed to: {value}");
        }
    }
}
