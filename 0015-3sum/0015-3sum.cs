public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();
            int sum = 0;
            //int mid = nums.Length / 2;
            for(int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int left = i+1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        List<int> triplet = new List<int>()
                        {
                            nums[i],
                            nums[left],
                            nums[right]
                        };
                        result.Add(triplet);
                        right--;
                        left++;
                        while (left < right && nums[left] == nums[left - 1])
                            left++;

                        while (left < right && nums[right] == nums[right + 1])
                            right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return result.ToArray();

    }
}