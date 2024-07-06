public class Solution {
    public int PassThePillow(int n, int time) {
         
        int cycleTime = 2 * (n - 1);
        int effectiveTime = time % cycleTime;

        
        if (effectiveTime < n) 
        {
            return effectiveTime + 1;
        } 
        else 
        {
            return cycleTime - effectiveTime + 1;
        }
    }
}