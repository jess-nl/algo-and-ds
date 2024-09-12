namespace Practice.Grind75.Easy
{
    public class ValidParentheses
    {
        public static bool IsValidVersion1(string s)
        {
            var arr = new List<char>();
            for (var i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(' || c == '[' || c == '{')
                {
                    arr.Add(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    // If arr is empty, it means there is no opening bracket
                    // available to match the current closing bracket.
                    // indicating an imbalance in the parentheses, and the string is invalid.
                    if (arr.Count == 0 || !IsPair(arr[arr.Count - 1], c))
                        return false;
                    arr.RemoveAt(arr.Count - 1);
                }
            }
            return arr.Count == 0;
        }

        public static bool IsPair(char opening, char closing)
        {
            if (opening == '(' && closing == ')')
                return true;
            if (opening == '[' && closing == ']')
                return true;
            if (opening == '{' && closing == '}')
                return true;
            return false;
        }

        public static bool IsValidVersion2(string s)
        {
            var stack = new Stack<char>();
            var brackets = new Dictionary<char, char>()
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' },
            };

            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (brackets.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else if (brackets.ContainsKey(c))
                {
                    if (stack.Count == 0 || brackets[c] != stack.Pop())
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
