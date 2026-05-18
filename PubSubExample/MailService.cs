namespace PubSubExample
{
    public class MailService
    {
        //this method will be called by the publisher (VideoEncoder) when the event is raised.
        public void OnVideoEncoded(object source, VideoEncodedEventArgs args)
        {
            Console.WriteLine("MailService: Sending an email...");
        }
    }
}
