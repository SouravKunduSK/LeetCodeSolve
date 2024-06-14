public class Solution {
    public int MinIncrementForUnique(int[] nums) {
      if(nums == null || nums.Length == 0) 
            return 0;

        Array.Sort(nums);
        int moves = 0;
        int increment = 0;
        for(int i = 1; i < nums.Length; ++ i)
        {
            if (nums[i] <= nums[i-1])
            {
                increment = nums[i-1] - nums[i] + 1;
                nums[i] += increment;
                moves += increment;
            }
        }
        return moves;
    }
}