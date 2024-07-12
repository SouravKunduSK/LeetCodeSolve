public class Solution {
    public int MaximumGain(string s, int x, int y) {
   int count = 0;
        var sList = s.ToList();

        void PairProcessing(char first, char second, int value)
        {
            for(int i = 0; i<sList.Count-1;)
            {
                if (sList[i]==first && sList[i+1]==second)
                {
                    count += value;
                    sList.RemoveAt(i);
                    sList.RemoveAt(i);
                    if (i > 0) 
                    { 
                        i -= 1; 
                    }
                }
                else
                {
                    ++i;
                }
            }
        }

        if(x>y)
        {
            PairProcessing('a', 'b', x);
            PairProcessing('b', 'a', y);
        }
        else
        {
            PairProcessing('b', 'a', y);
            PairProcessing('a', 'b', x);
        }

        return count;
    }
}