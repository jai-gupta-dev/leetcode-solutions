public class Solution {
    public bool IsPalindrome(int x) {
        string str = x.ToString();
        int i = 0;
        int j = str.Length - 1; //12121
        string finalans = "";
        while(i <= j){
            finalans += str[j];
            j--;
        }
        if(finalans == x.ToString()){
            return true;
        }
        return false;
    }
}