using System.Collections;

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

	public int[] Solve2(int[] nums, int target)
	{
		Dictionary<int, int> keys = new Dictionary<int, int>();

		int[] TargetNumbers = new int[2];
		int k = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			keys[nums[i]] = i;
		}
	
		for (int i = 0; i < nums.Length; i++)
		{
			var condition = target - nums[i];

			if (keys.ContainsKey(condition) && keys[condition] != i)
			{
				TargetNumbers[k] = i;
				TargetNumbers[++k] = keys[condition];
				return TargetNumbers;
			}
		}

		return null!;
	}
}