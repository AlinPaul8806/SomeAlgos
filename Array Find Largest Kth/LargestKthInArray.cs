namespace SomeAlgos.Array_Find_Largest_Kth
{
    public class LargestKthInArray
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var pq = new PriorityQueue<int, int>();
            foreach (var num in nums)
            {
                pq.Enqueue(num, -num);
                if (pq.Count > k)
                {
                    pq.Dequeue();
                }
            }
            return pq.Dequeue();
        }
    }
}
