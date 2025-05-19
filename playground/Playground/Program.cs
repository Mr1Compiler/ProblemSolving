using LeetCode.Problems;
using ProblemSolving.src.LeetCode.Problems.Array;
using System.Collections;

namespace playground;

public class Program
{
	public static void Main()
	{
		// Write and test code here -_-

		int[] nums = [1, 3, 5, 6];
		int target = 0;

		SearchInsert sl = new();

		Console.WriteLine(sl.Solve(nums, target));
	}
}