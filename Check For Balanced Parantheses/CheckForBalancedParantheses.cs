namespace SomeAlgos.Check_For_balanced_parantheses
{
    public class CheckForBalancedParantheses
    {
        public bool IsBalanced(string s)
        {
            var stack = new Stack<char>();
            foreach (var ch in s)
            {
                if (ch == '(') stack.Push(ch);
                else if (ch == ')')
                {
                    if (stack.Count == 0) return false;
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }
    }
}
