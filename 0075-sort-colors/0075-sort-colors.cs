public class Solution {
    public void SortColors(int[] nums) {
      for(int i=1; i<nums.Length; ++i)
        {
            for(int j = 1; j < nums.Length; ++j)
            {
                if (nums[j - 1] > nums[j])
                {
                    var temp = nums[j];
                    nums[j] = nums[j - 1];
                    nums[j - 1] = temp;
                }
            }
           
        }  
    }
}