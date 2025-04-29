using System.Linq;


namespace ProblemSolving.src.LeetCode.Problems.Array;

// complexity is high because of using Linq (bad solution)
// ill try to solve it in better way after diving into big O
public class RemoveDuplicates
{
	public int Solve(int[] nums)
	{
		int[] expectedNums = nums.Distinct().ToArray();

		int k = expectedNums.Length;

		for (int i = 0; i < k; i++)
		{
			nums[i] = expectedNums[i];
		}

		return k;
	}
}
