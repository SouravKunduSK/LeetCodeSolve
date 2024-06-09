public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        var reminderDictionary = new Dictionary <int, int>{{0,1}};
        int sum = 0;
        int count = 0;
        
        foreach(var num in nums)
        {
            sum +=num;
            int reminder = sum % k;
            
            if(reminder < 0)
            {
                reminder += k;
            }
            
            if(reminderDictionary.ContainsKey(reminder))
            {
                count += reminderDictionary[reminder];
                reminderDictionary[reminder]++;
            }
            else
            {
                reminderDictionary[reminder] = 1;
            }
        }
        
        return count;
    }
}