public class Solution {
    public bool JudgeSquareSum(int c) {
        
        int a, b, aSquare = 0, bSquare;
        
        int limit =(int) Math.Sqrt(c) + 1;
        for(a = 0; a <= limit; a++)
        {
            aSquare = a*a;
            bSquare = c-aSquare;
            
            
            b = (int) Math.Sqrt(bSquare);
            
            if(b*b == bSquare || a==0 && b==0)
                return true;
        }
        
        return false;
    }
}