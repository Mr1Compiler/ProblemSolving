using ProblemSolving.src.LeetCode.Problems.Array;
using System.Collections;

namespace playground;

public class Program
{
	public static void Main()
	{
		// Write and test code here -_-

		int[] nums = [3, 3];
		int target = 6;

		TwoSum sl = new TwoSum();

		foreach (int n in sl.Solve2(nums, target))
		{
			Console.WriteLine(n);
		}
	}
}