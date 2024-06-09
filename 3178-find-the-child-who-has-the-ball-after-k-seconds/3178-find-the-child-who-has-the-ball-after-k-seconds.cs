public class Solution {
    public int NumberOfChild(int n, int k) {
      int forward = k%(2*(n-1));
        
        if(forward<n)
            return forward;
        else
            return (2*(n-1))-forward;
    }
}