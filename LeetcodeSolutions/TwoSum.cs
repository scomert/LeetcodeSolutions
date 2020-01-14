using System.Collections.Generic;
using System.Linq;
namespace LeetcodeSolutions
{
    public class TwoSum
    {
        public int[] Solve(int[] nums, int target)
        {
            var complements = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (complements.TryGetValue(nums[i], out int index))
                {
                    return new int[] { index, i };
                }
                var complement = target - nums[i];
                complements.TryAdd(complement, i);
            }

            return new int[0];
        }
    }
}
