public class Solution {
    public string ReplaceWords(IList<string> dictionary, string sentence) {
         
        var roots = dictionary.ToList();
        var words = sentence.Split(" ");
        
        for(int i = 0; i < words.Length; ++i)
        {
            var replacement = words[i];
            
            foreach(var root in roots)
            {
                if((replacement.StartsWith(root)) && (root.Length<replacement.Length))
                {
                    replacement = root;
                }
            }
            words[i] = replacement;
        }
        
        return string.Join(" ", words);
    }
}