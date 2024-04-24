namespace Practice.NeetCode.Stack
{
    public static class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var brackets = new Dictionary<char, char>() {
                {'}', '{'},
                {']', '['},
                {')', '('},
            };

            foreach (char c in s)
            {
                if (!brackets.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (stack.Count == 0 || brackets[c] != stack.Pop())
                {
                    return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
