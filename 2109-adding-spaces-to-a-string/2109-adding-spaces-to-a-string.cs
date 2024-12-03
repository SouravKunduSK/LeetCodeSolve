public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        StringBuilder modifiedString = new StringBuilder();
        int spaceIndex = 0;
        for(int i = 0; i < s.Length; ++i)
        {
            if(spaceIndex < spaces.Length && i == spaces[spaceIndex])
            {
                modifiedString.Append(" ");
                ++spaceIndex;
            }
            modifiedString.Append(s[i]);
        }
        return modifiedString.ToString();
    }
}