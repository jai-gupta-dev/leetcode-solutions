public class Solution {
    public long MaximumTripletValue(int[] nums) {
      int n = nums.Length;

    // suffix[i] = maximum value from i to n-1
    long[] suffix = new long[n];

    suffix[n - 1] = nums[n - 1];

    for (int i = n - 2; i >= 0; i--)
    {
        suffix[i] = Math.Max(nums[i], suffix[i + 1]);
    }

    long maxLeft = nums[0];
    long answer = 0;

    for (int j = 1; j < n - 1; j++)
    {
        // Maximum nums[i] where i < j
        maxLeft = Math.Max(maxLeft, nums[j - 1]);

        // Maximum nums[k] where k > j
        long maxRight = suffix[j + 1];

        long value = (maxLeft - nums[j]) * maxRight;

        answer = Math.Max(answer, value);
    }

    return answer;
    }
}