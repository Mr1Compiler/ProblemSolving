namespace ProblemSolving.src.LeetCode.Problems.Array;
public class TwoSum
{
	// Its not perfect solution. becuase of Big O
	public int[] Solve(int[] nums, int target)
	{
		int[] TargetNumbers = new int[2];
		int k = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			for (int j = 0; j < nums.Length; j++)
			{
				if (nums[i] + nums[j] == target && i != j)
				{
					TargetNumbers[k] = i;
					TargetNumbers[++k] = j;
					return TargetNumbers;
				}
			}
		}
		return null!;
	}
}