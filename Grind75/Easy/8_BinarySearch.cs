namespace Practice.Grind75.Easy
{
    public class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            // SET left as 0
            var left = 0;
            // SET right as nums.Length - 1
            var right = nums.Length - 1;
            // SET mid as (left + right) / 2
            var mid = (left + right) / 2;
            // WHILE left <= right
            while (left <= right)
            {
                // IF target == nums[mid]
                if (nums[mid] == target)
                {
                    // RETURN mid
                    return mid;
                }
                // IF mid > target
                if (nums[mid] > target)
                {
                    // UPDATE right to be current mid
                    right = mid - 1;
                }
                // IF mid < target
                if (nums[mid] < target)
                {
                    // UPDATE left to be current mid
                    left = mid + 1;
                }
                // UPDATE mid to be (right + left) / 2
                mid = (right + left) / 2;
            }
            // RETURN -1
            return -1;
        }
    }
}
