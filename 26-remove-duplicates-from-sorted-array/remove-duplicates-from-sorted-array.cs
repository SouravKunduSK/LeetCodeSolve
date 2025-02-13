public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int length = nums.Length;
        if(length<1)
        return -1;
        int current_index = 1;
        for(int i = 1; i<length; ++i)
        {
            if(nums[i]!=nums[i-1])
            {
               nums[current_index] = nums[i];
               current_index ++;
            }
        }

        return current_index;
    }
}