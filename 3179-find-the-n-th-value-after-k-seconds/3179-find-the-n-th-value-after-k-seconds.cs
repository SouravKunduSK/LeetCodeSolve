public class Solution {
    public int ValueAfterKSeconds(int n, int k) {
        int MOD = 1000000007;
        
        int[] initial = new int[n];
        for(int i = 0; i < n; ++i){
            initial[i]=1;
        }
        
        for(int sec = 0; sec < k; ++sec)
        {
            int[] temp = new int [n];
            temp[0] = initial[0];
            
            for(int i = 1;i < n; ++i)
            {
                temp[i] = (temp[i-1] + initial[i])%MOD;
            }
            
            initial = temp;
        }
        
        return initial[n-1];
    }
}