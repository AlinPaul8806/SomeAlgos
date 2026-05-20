using System.Data.SqlTypes;

namespace SomeAlgos.Find_Longest_Substr_Without_repeating_chars
{
    /// <summary>
    /// Find the length of the longest substring without repeating characters.
    /// </summary>
    public class LongestSubstr
    {
        public int FindLenghtLongestSubstr(string s)
        {
            var set = new HashSet<char>();
            int left = 0, maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left++]);
                }
                set.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            return maxLength;
        }
    }
}
