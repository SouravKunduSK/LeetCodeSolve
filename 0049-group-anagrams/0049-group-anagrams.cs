public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var groupAnagrams = strs
                            .GroupBy(str=>new string(str.OrderBy(c=>c).ToArray()))
                            .Select(group=>(IList<string>)group.ToList())
                            .ToList<IList<string>>();
        
        return groupAnagrams;
    }
}