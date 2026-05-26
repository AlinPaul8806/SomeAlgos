namespace PubSubExample
{
    public class MessagingService
    {
        //this method will be called by the publisher (VideoEncoder) when the event is raised.
        public void OnVideoEncoded(object source, VideoEncodedEventArgs args)
        {
            Console.WriteLine("MessagingService: Sending a text message...");
        }
    }
}
