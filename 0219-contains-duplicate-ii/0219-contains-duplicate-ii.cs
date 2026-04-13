public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet <int> dataSet = new HashSet<int>();
        for(int i = 0; i < nums.Length; ++i)
        {
            if(dataSet.Contains(nums[i]))
            {
                return true;
            }
            dataSet.Add(nums[i]);
            if(dataSet.Count>k)
            {
                dataSet.Remove(nums[i-k]);
            }
        }
        return false;
    }
}