namespace LeetCode.Problems;

public class SearchInsert
{
    // O(N)
    public int Solve(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
                return i;

            else if (nums[i] > target)
                return i;
        }
        return nums.Length;
    }
}