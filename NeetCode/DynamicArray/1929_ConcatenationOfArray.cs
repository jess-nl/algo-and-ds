namespace Practice.NeetCode.DynamicArray
{
    public static class ConcatenationOfArray
    {
        public static int[] GetConcatenationVersion1(int[] nums)
        {
            var ans = new List<int>();

            for (var i = 0; i < 2; i++)
            {
                foreach (var num in nums)
                {
                    ans.Add(num);
                }
            }
            return ans.ToArray();
        }

        public static int[] GetConcatenationVersion2(int[] nums)
        {
            var ans = new int[nums.Length * 2];

            for (var i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
                ans[i + nums.Length] = nums[i]; // 🧠
            }
            return ans;
        }
    }
}
