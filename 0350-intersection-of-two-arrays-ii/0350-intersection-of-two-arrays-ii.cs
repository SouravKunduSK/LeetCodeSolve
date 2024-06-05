public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        
        var commonCounts = new Dictionary<int,int>();
        foreach(var c in nums1)
        {
            if(commonCounts.ContainsKey(c))
            {
                commonCounts[c]++;
            }
            else
            {
                commonCounts[c] = 1;
            }
        }
        var otherCounts = new Dictionary<int,int>();
        foreach(var c in nums2)
        {
            if(otherCounts.ContainsKey(c))
            {
                otherCounts[c]++;
            }
            else
            {
                otherCounts[c] = 1;
            }
        }
        foreach(var key in commonCounts.Keys.ToList())
        {
            if(otherCounts.ContainsKey(key))
            {
                commonCounts[key] = Math.Min(commonCounts[key],otherCounts[key]);
            }
            else
            {
                commonCounts[key] = 0;
            }
        }
        
        var result = new List<int>();
        foreach(var num in commonCounts)
        {
            for(int i=0; i<num.Value; ++i)
            {
                result.Add(Convert.ToInt32(num.Key));
            }
        }
        
        return result.ToArray();
        
    }
}