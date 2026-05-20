
namespace SomeAlgos.Reverse_Words_in_a_Sentence
{
    /// <summary>
    /// Reverse words in a sentence. For example, given "Hello World", return "World Hello".
    /// Rev
    public class ReverseWords
    {
        public string Reverse(string sentence)
        {
            var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(' ', words);
        }
    }
}
