public class Solution {
  public bool IsPalindrome(int x) {
    if(int.MaxValue - 1 < x || x < int.MinValue) {
        return false;
    }
    string y = x.ToString();
    int length = y.Length;
    for(var i = 0; i < length / 2; i ++) {
        if(y[i] != y[length - 1 - i]) {
            return false;
        }
    }
    
    return true;
}
}