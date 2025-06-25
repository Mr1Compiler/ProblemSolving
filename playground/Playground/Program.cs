using LeetCode.Problems;
using ProblemSolving.src.LeetCode.Problems.Array;
using System.Collections;
using RandomProblems.Problems;


namespace playground;

public class Program
{
	public static void Main()
	{
		// Write and test code here -_-

		FindMissingNumber fmn = new FindMissingNumber();

		int num = fmn.Sovle(new int[] { 1 });

		Console.WriteLine(num);
	}
}


/*
      FindMissingNumber(new int[] { 3, 0, 1 }) → 2
      FindMissingNumber(new int[] { 0, 1 }) → 2
      FindMissingNumber(new int[] { 1 }) → 0
      FindMissingNumber(new int[] { 0 }) → 1
*/
