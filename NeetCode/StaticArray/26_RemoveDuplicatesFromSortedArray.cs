namespace Practice.NeetCode.StaticArray
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int CountUniqueNumbers(int[] nums)
        {
            var l = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[l] = nums[i];
                    l++;
                }
            }
            return l;
        }

        public static int[] DisplayUniqueNumbers(int[] nums)
        {
            var l = 1;
            var uniqueNumbers = new List<int>() { nums[0] };

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                    uniqueNumbers.Add(nums[i]);
            }

            return uniqueNumbers.ToArray();
        }
    }
}
