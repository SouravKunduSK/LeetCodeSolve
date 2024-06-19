public class Solution {
    public int MinDays(int[] bloomDay, int m, int k) {
        if(bloomDay.Length < m*k)
        {
            return -1;
        }
        
        int left = 0;
        int right = int.MaxValue;
        
        while(left<right)
        {
            int mid = left + (right - left) / 2;
            
            if(CanMakeBouquets(bloomDay,m,k,mid))
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        
        return CanMakeBouquets(bloomDay,m,k,left)? left:-1;
    }
    
    public bool CanMakeBouquets(int[] bloomDay, int m, int k, int day)
    {
        int bouquets = 0;
        int flowers = 0;
        
        foreach(var bloom in bloomDay)
        {
            if(bloom<=day)
            {
                flowers++;
                if(flowers == k)
                {
                    bouquets++;
                    flowers = 0;
                }
            }
            else
            {
                flowers = 0;
            }
            
            if(bouquets >= m)
            {
                return true;
            }
        }
        return false;
    }
}