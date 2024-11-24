public class Solution {
    public int ClimbStairs(int n) {
        if(n<=2)
            return n;
        int step1 = 1;
        int step2 = 2;
        int temp = 0;
        for(int i = 3; i<=n;++i)
        {
            temp = step1+step2;
            step1 = step2;
            step2 = temp;
        }
        return temp;
    }
}