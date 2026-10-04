public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
     if (nums1.Length > nums2.Length)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int m = nums1.Length;
        int n = nums2.Length;

        int low = 0;
        int high = m;

        while (low <= high)
        {
            int partition1 = (low + high) / 2;

            int partition2 = (m + n + 1) / 2 - partition1;

            int left1 = partition1 == 0
                ? int.MinValue
                : nums1[partition1 - 1];

            int right1 = partition1 == m
                ? int.MaxValue
                : nums1[partition1];

            int left2 = partition2 == 0
                ? int.MinValue
                : nums2[partition2 - 1];

            int right2 = partition2 == n
                ? int.MaxValue
                : nums2[partition2];
            if (left1 <= right2 && left2 <= right1)
            {
                if ((m + n) % 2 == 1)
                {
                    return Math.Max(left1, left2);
                }

                return (Math.Max(left1, left2)
                        + Math.Min(right1, right2)) / 2.0;
            }

            if (left1 > right2)
            {
                high = partition1 - 1;
            }
            else
            {
                low = partition1 + 1;
            }
        }

        return 0.0;
    }
}