public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        List<int> newdata = new List<int>();
        int i = 0;
        int j = 0;
        while(i<m && j<n){
            if(nums1[i] <= nums2[j]){
                newdata.Add(nums1[i]);
                i++;
            }
            else{
                newdata.Add(nums2[j]);
                j++;
            }
        }
        while(i<m){
            newdata.Add(nums1[i]);
            i++;
        }
        while(j<n){
            newdata.Add(nums2[j]);
            j++;
        }
        for (int k = 0; k < newdata.Count; k++)
        {
            nums1[k] = newdata[k];
        }
    }
}