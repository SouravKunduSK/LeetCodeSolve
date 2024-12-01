public class Solution {
    public bool CheckIfExist(int[] arr) {
        HashSet<int> exists = new HashSet<int>();
        foreach(var number in arr)
        {
            if(exists.Contains(2*number)||((number%2==0)&&exists.Contains(number/2)))
            {
                return true;
            }
            exists.Add(number);
        }
        return false;
    }
}