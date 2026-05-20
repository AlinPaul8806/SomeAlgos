namespace SomeAlgos.Count_Vovels_and_Consonants
{
    internal class CountVovelsAndConsonants
    {
        public (int vovels, int consonants) Count(string input)
        { 
            int vovels = 0;
            int consonants = 0;

            foreach (char c in input)
            {
                if ("aeiou".Contains(char.ToLower(c)))
                {
                    vovels++;
                } 
                else if (char.IsLetter(c))
                {
                    consonants++;
                }
            }
            return (vovels, consonants);    
        }
    }
}
