public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> value = new Dictionary<int,int>();
    int need = 0;
        for(int i=0;i<nums.Length;i++){
            need = target - nums[i];
            if(value.ContainsKey(need)){
                return new int[]{value[need],i};
            }
            else if(!value.ContainsKey(nums[i])){
                value.Add(nums[i], i); 
            }
        }
        return new int[]{};
    }
}