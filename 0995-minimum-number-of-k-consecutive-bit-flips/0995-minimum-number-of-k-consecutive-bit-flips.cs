public class Solution {
    public int MinKBitFlips(int[] nums, int k) {
        int n = nums.Length;
        int flips = 0;
        int current_flips = 0;
        int[] flip = new int[n];
        
        for (int i = 0; i < n; i++) {
            
            if (i >= k) {
                current_flips -= flip[i - k];
            }

            
            if ((nums[i] + current_flips) % 2 == 0) {
                if (i + k > n) 
                    return -1; 
                
                flips++;
                current_flips++;
                flip[i] = 1;
            }
        }
        
        return flips;
    }
}