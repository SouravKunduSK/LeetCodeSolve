public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        for(int i = 1; i<n; ++i)
        {
            int j = n-i;
            if(IsNoZero(i)&&IsNoZero(j))
            {
                return new int[] {i, j};
            }
        }
        return new int[] {};
    }
    public bool IsNoZero(int num)
    {
        while(num>0)
        {
            if(num%10 == 0)
            {
                return false;
            }
            num /=10;
        }
        return true;
    }
}