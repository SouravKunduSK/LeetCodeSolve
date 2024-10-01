public class Solution {
    public bool CanArrange(int[] arr, int k) {
        int[] remainderCounts = new int[k];
        
        foreach(int number in arr)
        {
            remainderCounts[FindRemainder(number,k)]++;
        }
        
        for(int i = 1; i<k; ++i)
        {
            if(remainderCounts[i] != remainderCounts[k-i])
            {
                return false;
            }
        }
        
        if(remainderCounts[0]%2!=0)
        {
            return false;
        }
        
        return true;
    }
    
    public static int FindRemainder(int x, int k)
    {
        return ((x % k) + k) % k;
    }
}