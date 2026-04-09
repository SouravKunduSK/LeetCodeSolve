public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();
        for(int i = 0; i <nums.Length; ++i)
        {
            if(seen.Contains(nums[i]))
            {
                return true;
            }
            seen.Add(nums[i]);
        }
        return false;
    }
}