public class Solution {
    public int AppendCharacters(string s, string t) {
        int m = s.Length;
        int n = t.Length;
        int j = 0;
        
        for(int i = 0; i<m;++i)
        {
            if(j<n && s[i]==t[j])
            {
                ++j;
            }
        }
        return n-j;
    }
}