public class Solution {
    public int Search(int[] nums, int target) {
        if(nums.Count()<1 || nums == null)
            return -1;
        int start = 0;
        int end = nums.Length - 1;
        while(start<=end)
        {
            var mid = start+(end-start)/2;
            if(nums[mid]>target)
                end = mid-1;
            else if(nums[mid]<target)
                start = mid+1;
            else
                return mid;
        }
        return -1;
    }
    
}