public class Solution {
    public string ClearDigits(string s) {
        var charList = s.ToList();
        
        while(true)
        {
            bool digitFound = false;
            for(int i = 0; i < charList.Count; ++i)
            {
                if(char.IsDigit(charList[i]))
                {
                    digitFound = true;
                    charList.RemoveAt(i);
                
                
                for(int j = i-1; j>=0; --j)
                {
                    if(!char.IsDigit(charList[j]))
                    {
                        charList.RemoveAt(j);
                        break;
                    }
                }
                
                break;
               }
            }
            
            if(!digitFound)
                break;
        }
        
        
        
        return new string(charList.ToArray());
    }
}