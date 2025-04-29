using LeetCode.Problems;
using ProblemSolving.src.LeetCode.Problems.Array;
using System.Collections;

namespace playground;

public class Program
{
	public static void Main()
	{
		// Write and test code here -_-

		int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
		int val = 2;

		RemoveElement sl = new RemoveElement();

		//Console.WriteLine(sl.Solve2(nums, val));
		Console.WriteLine(sl.Solve2(nums, val));
	}
}