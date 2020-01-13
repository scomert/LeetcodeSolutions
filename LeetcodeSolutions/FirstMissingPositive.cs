using System.Linq;

namespace LeetcodeSolutions
{
    public class FirstMissingPositive
    {
        public int Solution(int[] nums)
        {
            var d = nums
                .Distinct()
                .ToDictionary(key => key, val => val);

            for (int i = 1; i < int.MaxValue; i++)
            {
                if (!d.ContainsKey(i))
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
