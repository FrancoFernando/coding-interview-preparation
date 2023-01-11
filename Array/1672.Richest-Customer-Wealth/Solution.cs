public class Solution {
    public int MaximumWealth(int[][] accounts) {
        
        int maxWealth = 0;
        for (int customer = 0; customer < accounts.Length; ++customer) {
            maxWealth = Math.Max(maxWealth, accounts[customer].Sum());
        }
        return maxWealth;
    }
}

// Better LINQ optimization

public class Solution {
    public int MaximumWealth(int[][] accounts) {
        return accounts
                .Select(cust => cust.Sum())
                .Max();
    }
}
