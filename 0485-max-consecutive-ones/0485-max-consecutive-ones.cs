public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        if(nums.Length<0)
            return -1;
        int max = 0;
        int currentCount = max;
        foreach(var num in nums)
        {
            if(num==0)
                currentCount = 0;
            else
            {
                currentCount++;
                max = Maximum(max, currentCount);
            }

        }
        return max;
    }
    
    public static int Maximum(int max, int currentCount)
    {
        if(max>currentCount)
            return max;
        else
            return currentCount;
    }
}