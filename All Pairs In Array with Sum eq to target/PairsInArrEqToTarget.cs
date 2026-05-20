namespace SomeAlgos.All_Pairs_In_Array_with_Sum_eq_to_target
{
    public class PairsInArrEqToTarget
    {
        public List<Tuple<int, int>> FindPairs(int[] arr, int target)
        {
            var result = new List<Tuple<int, int>>();
            var seen = new HashSet<int>();

            foreach (var num in arr)
            {
                var neededNr = target - num;
                if (seen.Contains(neededNr))
                {
                    result.Add(Tuple.Create(neededNr, num));
                }
                seen.Add(num);
            }
            return result;
        }
    }
}
