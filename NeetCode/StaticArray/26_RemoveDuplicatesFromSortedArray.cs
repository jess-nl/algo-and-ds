﻿namespace Practice.NeetCode.StaticArray
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
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
    }
}
