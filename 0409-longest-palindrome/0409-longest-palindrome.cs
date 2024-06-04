public class Solution {
    public int LongestPalindrome(string s) {
        var charCount = s.GroupBy(c=>c)
                        .Select(g=>g.Count());
        int length = charCount.Sum(count=>count/2*2);
        bool isOdd = charCount.Any(count=>count%2==1);
        
        if(isOdd)
        {
            length++;
        }
        
        return length;
    }
}