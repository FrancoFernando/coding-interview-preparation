# Description 

You are given an array prices where prices[i] is the price of a given stock on the ith day, and an integer fee representing a transaction fee.

Find the maximum profit you can achieve. You may complete as many transactions as you like, but you need to pay the transaction fee for each transaction.

Note:

You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).
The transaction fee is only charged once for each stock purchase and sale.
 

Example 1:

Input: prices = [1,3,2,8,4,9], fee = 2
Output: 8
Explanation: The maximum profit can be achieved by:
- Buying at prices[0] = 1
- Selling at prices[3] = 8
- Buying at prices[4] = 4
- Selling at prices[5] = 9
The total profit is ((8 - 1) - 2) + ((9 - 4) - 2) = 8.
Example 2:

Input: prices = [1,3,7,5,10,3], fee = 3
Output: 6
 

Constraints:

1 <= prices.length <= 5 * 104
1 <= prices[i] < 5 * 104
0 <= fee < 5 * 104

# Thought Process

This is a dynamic programming problem: we need to try all the possible combinations of buying and salling stocks and subproblems overlap.

At any given day, we can be in one of two states:
a) Holding a stock
b) Not holding a stock

If we're holding a stock, we can:
a) Continue holding it
b) Sell it (and pay the transaction fee)
If we're not holding a stock, we can:
a) Continue not holding
b) Buy a stock

The top-down recursive solution uses the following structure:

- index (current day)
- canBuy (boolean indicating if we can buy a stock)

The bottom-up solution uses the following recurrence:

hold[i] = max(hold[i-1], notHold[i-1] - prices[i])
notHold[i] = max(notHold[i-1], hold[i-1] + prices[i] - fee)

where

hold[i]: Maximum profit on day i if we're holding a stock
notHold[i]: Maximum profit on day i if we're not holding a stock

# Complexity

O(N) time
