public class Solution {
    public int MinDifference(int[] nums) {
        if(nums.Length<=4)
        {
            return 0;
        }
        
        Array.Sort(nums);
        
        int length = nums.Length;
        int minDifference = int.MaxValue;
        
        
        minDifference = Math.Min(minDifference, nums[length-1] - nums[3]);
        
        minDifference = Math.Min(minDifference, nums[length-2] - nums[2]);
        
        minDifference = Math.Min(minDifference, nums[length-3] - nums[1]);
            
        minDifference = Math.Min(minDifference, nums[length-4] - nums[0]);
        
        return minDifference;
    }
}