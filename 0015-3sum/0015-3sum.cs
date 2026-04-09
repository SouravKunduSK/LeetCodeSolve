public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        int length = nums.Length;
        if(nums == null || length < 3)
        return result;
        Array.Sort(nums);

        for(int i = 0; i < length-2; ++i)
        {
            if(i > 0 && nums[i] == nums[i-1])
            continue;

            int target = - nums[i];
            int left = i + 1;
            int right = length - 1;

            while(left < right)
            {
                int sum = nums[left] + nums[right];
                if(sum == target)
                {
                    result.Add(new List<int> {nums[i], nums[left], nums[right]});

                    while (left < right && nums[left] == nums[left + 1]) 
                    left++;
                    while (left < right && nums[right] == nums[right - 1]) 
                    right--;


                    left ++;
                    right --;
                }
                else if(sum < target)
                left ++;
                else
                right --;
            }
        }
        return result;
    }
}