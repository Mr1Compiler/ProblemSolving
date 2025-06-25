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

		FirstNonRepeating firstNonRepeating = new FirstNonRepeating();

		int num = firstNonRepeating.Solve(new int[] { 4, 5, 1, 2, 0, 4 });

    	Console.WriteLine(num);
	}
}
