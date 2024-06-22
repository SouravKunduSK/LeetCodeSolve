public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        int n = nums.Length;
        int count = 0, oddCount = 0;
        var prefixCounts = new Dictionary<int, int>();
        prefixCounts[0] = 1;

        foreach (int num in nums) {
            if (num % 2 != 0) {
                oddCount++;
            }

            if (prefixCounts.ContainsKey(oddCount - k)) {
                count += prefixCounts[oddCount - k];
            }

            if (!prefixCounts.ContainsKey(oddCount)) {
                prefixCounts[oddCount] = 0;
            }
            prefixCounts[oddCount]++;
        }

        return count;
    }
}