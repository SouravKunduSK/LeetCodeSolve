public class Solution {
    public IList<string> CommonChars(string[] words) {
      var commonCharCounts = new Dictionary<char,int>();
        foreach(char c in words[0])
        {
            if(commonCharCounts.ContainsKey(c))
            {
                commonCharCounts[c]++;
            }
            else
            {
                commonCharCounts[c] = 1;
            }
        }
        
        for(var i = 1; i < words.Length; ++i)
        {
            var otherCharCounts = new Dictionary<char,int>();
            foreach(var c in words[i])
            {
                if(otherCharCounts.ContainsKey(c))
                {
                    otherCharCounts[c]++;
                }
                else
                {
                    otherCharCounts[c] = 1;
                }
            }
            
            foreach( var key in commonCharCounts.Keys.ToList())
            {
                if(otherCharCounts.ContainsKey(key))
                {
                    commonCharCounts[key] = Math.Min(commonCharCounts[key], otherCharCounts[key]);
                }
                else
                {
                    commonCharCounts[key] = 0;
                }
                
            }
        }
        
        var result  = new List<string>();
        foreach(var key in commonCharCounts)
        {
            for(int i = 0; i< key.Value; ++i)
            {
                result.Add(key.Key.ToString());
            }
        }
        
        return result;
    }
}