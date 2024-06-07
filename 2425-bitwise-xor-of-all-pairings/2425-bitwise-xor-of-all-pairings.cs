public class Solution {
    public int XorAllNums(int[] nums1, int[] nums2) {
        int result = 0;
      if(nums1.Length%2!=0)
      {
          foreach(var num in nums2)
          {
              result^=num;
          }
      }
        if(nums2.Length%2!=0)
        {
            foreach(var num in nums1)
            {
                result ^= num;
            }
        }
      
        return result;
    }
}