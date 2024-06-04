public class Solution {
    public bool IsAnagram(string s, string t) {
   
        if(s.Length!=t.Length)
            return false;
        
        var sample = s.ToCharArray();
        var target = t.ToCharArray();
        
        Array.Sort(sample);
        Array.Sort(target);
        
        for(int i = 0; i<sample.Length; ++i)
        {
            if(sample[i]!=target[i])
                return false;
        }
        
        return true;
    }
}