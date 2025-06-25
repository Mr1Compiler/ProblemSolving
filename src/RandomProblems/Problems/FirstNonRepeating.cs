namespace RandomProblems.Problems;

public class FirstNonRepeating
{
    public int Solve(int[] nums)
    {
        // Starting
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
                dict[num]++;
            else
                dict[num] = 1;
        }

        foreach (var num in nums)
        {
            if (dict[num] == 1)
                return num;
        }
        
        return -1;
    }
}