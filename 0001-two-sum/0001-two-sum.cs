public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> value = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int newvalue = target - nums[i];
            if(value.ContainsKey(newvalue)){
                return new int[] {value[newvalue],i};
            }
            value[nums[i]] = i;
        }
        return new int[] {0};
    }
}