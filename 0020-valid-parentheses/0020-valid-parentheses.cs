public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>(); //LIFO
        foreach(char ch in s){
            if(ch == '(' || ch == '[' || ch == '{'){
                stack.Push(ch);
            }
            else{
                if (stack.Count == 0)
                        return false;
                char se = stack.Pop();

                if(ch == ')' && se != '(' || 
                ch == ']' && se != '[' ||
                ch == '}' && se != '{'){
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}