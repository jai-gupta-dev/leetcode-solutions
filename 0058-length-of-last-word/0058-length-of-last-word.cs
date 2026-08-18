public class Solution {
    public int LengthOfLastWord(string s) {
        //List<string> target = new List<int>();

        if(s.Length == 0){
            return 0;
        }
       string[] words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int check = words.Length - 1;
            return words[check].Length;
    }
}