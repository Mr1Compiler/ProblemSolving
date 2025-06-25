namespace RandomProblems.Problems;

public class FrequentElement
{
    public int MostFrequentElement(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
                dict[num]++;
            else
                dict[num] = 1;
        }

        int maxFrequency = 0;
        int result = int.MaxValue;


        foreach (var pair in dict)
        {
            if (pair.Value > maxFrequency
                || (pair.Value == maxFrequency && pair.Key < result)
               )
            {
                maxFrequency = pair.Value;
                result = pair.Key;
            }
        }

        return result;
    }
}