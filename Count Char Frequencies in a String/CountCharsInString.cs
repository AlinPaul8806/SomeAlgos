
using System.Diagnostics.Metrics;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SomeAlgos.Count_Char_Frequencies_in_a_String
{
    /// <summary>
    /// Exercise description:
    //  Implement the CountCharacterFrequencies method that takes a string and returns a dictionary mapping each character
    // to the number of times it appears in the input.
    // The method should be case-sensitive, so 'H' and 'h' are treated as different characters.
    // All characters, including spaces and symbols, should be counted.
    /// </summary>
    
    public class CountCharsInString
    {
        public Dictionary<char, int> CountCharacterFrequencies(string input)
        {
            var resultDictionary = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (resultDictionary.ContainsKey(c))
                {
                    resultDictionary[c]++; // increment existing count
                }
                else
                {
                    resultDictionary[c] = 1; // add new character with count 1
                }
            }

            return resultDictionary;
        }
    }
}
