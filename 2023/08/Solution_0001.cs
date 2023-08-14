/// <summary>
/// 1. Two Sum
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
/// </summary>
public class Solution_0001
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> last = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (last.ContainsKey(target - nums[i]))
            {
                return new[] {last[target - nums[i]], i};
            }
            else
            {
                last.Add(nums[i], i);
            }
        }

        return new[] {0, 0};
    }
}