namespace PubSubExample
{
    public class VideoEncodedEventArgs : EventArgs
    {
        public string? VideoTitle { get; set; }
        public int DurationInSeconds { get; set; }
        public DateTime EncodedAt { get; set; }
    }
}
