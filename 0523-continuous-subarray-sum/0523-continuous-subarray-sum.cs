public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        if(nums.Length==0 || k == 0)
            return false;
        
        var reminderDictionary = new Dictionary <int, int>{ {0, -1} };
        int sum = 0;
        var reminder = 0;
        for(int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
            if(k!=0)
            {
                reminder = sum % k; 
            }
            
            if(reminderDictionary.ContainsKey(reminder))
            {
                if(i - reminderDictionary[reminder]>=2)
                    return true;
            }
            else 
                reminderDictionary[reminder] = i;
        }
        
        return false;
    }
}