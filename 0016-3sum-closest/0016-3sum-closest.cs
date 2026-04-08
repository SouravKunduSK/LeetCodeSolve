public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int l = nums.Length;
        if(l<3)
        return 0;

        Array.Sort(nums);
        int closest =nums[0] + nums[1] + nums[2];

        for(int i = 0; i < l-2; ++i)
        {
            int left = i+1;
            int right = l-1;

            while(left<right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if(Math.Abs(target - sum) < Math.Abs(target - closest))
                {
                    closest = sum;
                }

                if(sum<target)
                left++;
                else if(sum>target)
                right--;
                else
                return sum;
            }
        }
        return closest;
    }
}