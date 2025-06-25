namespace RandomProblems.Problems;

public class FindMissingNumber
{
    public int Sovle(int[] nums)
    {
        int arrSum = 0;
        int realSum = 0;
        int maxNum = 0;
        bool hasZero = false;
        
        foreach (var num in nums)
        {
            if (maxNum < num)
                maxNum = num;

            if (num == 0)
                hasZero = true;
            arrSum += num;
        }

        for (int i = 0; i <= maxNum; i++)
        {
            realSum += i;
        }

        int result = realSum - arrSum;

        if (result == 0)
        {
            if (hasZero)
                return (maxNum + 1);
            else
                return 0;
        }
        else
            return result;
    }
}


/*
      FindMissingNumber.Solve(new int[] { 3, 0, 1 }) → 2  
      FindMissingNumber.Solve(new int[] { 0, 1 }) → 2  
      FindMissingNumber.Solve(new int[] { 1 }) → 0  
      FindMissingNumber.Solve(new int[] { 0 }) → 1
      
      
      1 + 2 + 3 + 4 + 5
*/