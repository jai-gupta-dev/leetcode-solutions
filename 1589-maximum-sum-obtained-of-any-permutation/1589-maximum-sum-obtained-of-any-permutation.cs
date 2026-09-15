public class Solution {
    public int MaxSumRangeQuery(int[] nums, int[][] requests) {
        int n = nums.Length;
        int[] freq = new int[n + 1];

        foreach (var request in requests)
        {
            int left = request[0];
            int right = request[1];

            freq[left]++;
            freq[right + 1]--;
        }

        for (int i = 1; i < n; i++)
        {
            freq[i] += freq[i - 1];
        }

        Array.Sort(nums);

        Array.Sort(freq, 0, n);

        long result = 0;

        for (int i = 0; i < n; i++)
        {
            result += (long)nums[i] * freq[i];
        }

        return (int)(result % 1000000007);
    }
}