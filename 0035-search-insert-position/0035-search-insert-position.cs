public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0;
        int j = 0;
        while(left < nums.Length){
            if(nums[left] == target){
                return left;
            }
            else if(nums[left] < target){
                left++;
            }
            else if(nums[left] > target){
                return left;
            }
        }
return nums.Length;
    }
}