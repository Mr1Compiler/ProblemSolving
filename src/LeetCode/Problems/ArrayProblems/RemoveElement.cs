namespace LeetCode.Problems;
public class RemoveElement
{
	// Runtime => 1ms
	public int Solve(int[] nums, int val)
	{
		Stack<int> newNums = new Stack<int>();
		int k = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == val)
				continue;

			newNums.Push(nums[i]);
		}

		k = newNums.Count;
		int[] expectedNums = newNums.ToArray();


		for (int i = 0; i < expectedNums.Length; i++)
		{
			nums[i] = expectedNums[i];

		}

		return k; 
	}

	// Runtime => 0ms =>  I beat the most => from 1 to 0ms 🔥🔥
	public int Solve2(int[] nums, int val)
	{
		int[] expectedNums = new int [100];
		int k = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == val)
				continue;

			expectedNums[k] = nums[i];
			k++;
		}

		for (int i = 0; i < nums.Length; i++)
		{
			nums[i] =  expectedNums[i];
		}

		return k;
	}
}
