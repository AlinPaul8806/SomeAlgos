namespace PubSubExample
{
    public class VideoEncoder
    {
        // The publisher has a list of subscriber methods it needs to call when something happens.
        // When you do +=, you're just adding your method to that list.
        // When the publisher "raises" the event, it simply loops through that list and calls every method on it.

        
        // This is the "list" I was talking about.
        public event EventHandler<VideoEncodedEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video..." );
            // encoding logic here...

            var args = new VideoEncodedEventArgs
            {
                VideoTitle = video.Title,
                DurationInSeconds = video.DurationInSeconds,
                EncodedAt = DateTime.Now
            };

            VideoEncoded?.Invoke(this, args);
        }
    }
}
