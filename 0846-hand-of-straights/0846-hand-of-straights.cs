public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if(hand.Length % groupSize != 0)
            return false;
        Array.Sort(hand);
        var handList = hand.ToList();
        
        while(handList.Count > 0)
        {
            int first = handList[0];
            
            for(int i = 0; i < groupSize; ++i)
            {
                if(!handList.Remove(first+i))
                    return false;
            }
        }
        return true;
    }
}