/// <summary>
/// 215. Kth Largest Element in an Array
/// Given an integer array nums and an integer k, return the kth largest element in the array.
/// Note that it is the kth largest element in the sorted order, not the kth distinct element.
/// Can you solve it without sorting?
/// </summary>
internal class Solution_0215
{
    public static int FindKthLargest(int[] nums, int k)
    {
        int[] sorted = new int[k];
        int minInSorted = int.MinValue;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > minInSorted)
            {
                minInSorted = PutInSorted(sorted, nums[i], k);
            }
        }

        return minInSorted;
    }

    private static int PutInSorted(int[] sorted, int num, int count)
    {
        bool isAdded = false;
        for (int i = 0; i < count - 1; i++)
        {
            if (sorted[i] <= num && sorted[i + 1] > num)
            {
                sorted[i] = num;
                isAdded = true;
                break;
            }
            else
            {
                sorted[i] = sorted[i + 1];
            }
        }

        if (!isAdded)
        {
            sorted[count - 1] = num;
        }

        return sorted[0];
    }
}