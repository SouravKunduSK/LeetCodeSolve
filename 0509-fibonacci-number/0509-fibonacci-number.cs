public class Solution {
    public int Fib(int n) {
        if(n<0 || n>30)
            return 0;
        int num1 = 0;
        int num2 = 1;
        int temp =0;
        if(n==0)
            return 0;
        if(n==1)
            return 1;
        for(int i = 2; i<=n;++i)
            {
                temp = num1+num2;
                num1 = num2;
                num2 = temp;
            }
            return temp;                

        }
}