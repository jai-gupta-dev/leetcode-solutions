
class Solution {
    public int ClimbStairsHelper(int n , int[] dp)
    {
        if (n == 1)
            return 1;
        if(n == 2)
        {
            return 2;
        }
        
        if(dp[n] != -1)
        {
            return dp[n];
        }
        int p = ClimbStairsHelper(n-1,dp)+ClimbStairsHelper(n-2,dp);
        dp[n] = p;
        return p;
    }
    public int climbStairs(int n) {
        int[] dp = new int[n+1];

        Arrays.fill(dp,-1);

        return ClimbStairsHelper(n,dp);
    }
}