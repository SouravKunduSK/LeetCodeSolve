/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        if(n<1)
            return -1;
        
        int start = 1;
        int end = n;
        while(start<end)
        {
            int mid = start+(end-start)/2;
            if(IsBadVersion(mid))
                end = mid;
            else
                start = mid+1;
        }
        return start;
    }
}