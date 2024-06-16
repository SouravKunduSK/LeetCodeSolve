public class Solution {
    public int MinPatches(int[] nums, int n) {
    long miss = 1; 
    int patches = 0;
    int i = 0;
    int len = nums.Length;
    
    while (miss <= n) {
        if (i < len && nums[i] <= miss) 
        {
            miss += nums[i];
            i++;
         } 
        else 
        {
            miss += miss;
            patches++;
        }
    }
    
    return patches;
    }
}