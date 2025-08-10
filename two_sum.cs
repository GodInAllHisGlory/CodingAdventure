using System;

namespace CodingStuff
{
    class TwoSum
    {
        public int[] twoSum(int[] nums, int target)
        {
            Dictionary<int, int> numHash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numHash.ContainsKey(nums[i]))
                {
                    numHash.Remove(nums[i]);
                }
                numHash.Add(nums[i], i);
            }

            for (int j = 0; j < nums.Length; j++)
            {
                int x = target - nums[j];
                if (numHash.ContainsKey(x) && numHash[x] != j)
                {
                    return [j, numHash[x]];
                }
            }
            return [0, 0];
        }
    }
}