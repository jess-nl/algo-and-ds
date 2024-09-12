namespace Practice.Grind75.Easy
{
    public class TwoSum
    {
        public static int[] TwoSumVersion1(int[] nums, int target)
        {
            // SET empty arr
            var arr = new List<int>();
            // FOR each element (i) in nums
            for (var i = 0; i < nums.Length; i++)
            {
                // FOR each element (j) in nums ; SET j = i + 1
                for (var j = i + 1; j < nums.Length; j++)
                    // IF target - j
                    if (target - nums[i] == nums[j])
                    {
                        // RETURN [ i, j ]
                        return new int[] { i, j };
                    }
            }
            // RETURN null
            return new int[] { };
        }

        public static int[] TwoSumVersion2(int[] nums, int target)
        {
            // SET dictionary
            var dictionary = new Dictionary<int, int>() { };
            // FOR each element in nums
            for (var i = 0; i < nums.Length; i++)
            {
                // SET missing (target - element)
                var missing = target - nums[i];
                // IF dictionary contains missing
                if (dictionary.ContainsKey(missing))
                {
                    // RETURN arr of [dictionary[missing], index]
                    return new int[] { dictionary[missing], i };
                }
                // ADD [element, index] to dictionary
                dictionary[nums[i]] = i;
            }
            // RETURN empty arr
            return new int[] { };
        }
    }
}
