namespace DelegatesEventsLambdas.EventsPubSub
{
    class Subscriber
    {
        // Subscribe to the event
        internal static void HandleFlagValueChanged(int value)
        {
            Console.WriteLine($"Flag value changed to: {value}");
        }
    }
}
