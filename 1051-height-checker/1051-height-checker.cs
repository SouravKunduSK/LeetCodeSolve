public class Solution {
    public int HeightChecker(int[] heights) {
        int count = 0;
        int[] expected = new int[heights.Length] ;
        heights.CopyTo(expected, 0) ;
        Array.Sort(expected) ;

        for (int i = 0; i < heights.Length; ++i)
        {
            if (heights[i] != expected[i])
            {
                count++;
            }
                
        }

        return count;
    }
}