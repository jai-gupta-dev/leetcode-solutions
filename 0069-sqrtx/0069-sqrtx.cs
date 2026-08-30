public class Solution {
    public int MySqrt(int x) {
        if(x == 1 || x==2){
            return 1;
        }
        long a = 0;
        for(long i=1;i<x;i++){
            a = i * i;
            if(a == x){
                return (int)(i);
            }
            if(a > x)
                {
                    return (int)(i - 1);
                }
        }
        return 0;
    }
}