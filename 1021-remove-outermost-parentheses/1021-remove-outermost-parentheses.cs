public class Solution {
    public string RemoveOuterParentheses(string s) {
        string result = "";
        int depth = 0;

        foreach(char i in s){
            if(i == '('){
                if(depth > 0){
                    result += i;
                }
                depth++;
            }
            else{
                depth--;
                if(depth > 0){
                    result+=i;
                }
            }
        }
        return result;
    }
}