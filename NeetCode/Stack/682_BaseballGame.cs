namespace Practice.NeetCode.Stack
{
    public static class BaseballGame
    {
        public static int CalPoints(string[] operations)
        {
            var stack = new List<int>();
            foreach (string operation in operations)
            {
                if (operation == "D")
                {
                    stack.Add(stack[stack.Count() - 1] * 2);
                }
                else if (operation == "+")
                {
                    stack.Add(stack[stack.Count() - 2] + stack[stack.Count() - 1]);
                }
                else if (operation == "C")
                {
                    stack.Remove(stack[stack.Count() - 1]);
                }
                else
                {
                    stack.Add(int.Parse(operation));
                }
            }

            return stack.Sum();
        }
    }
}
