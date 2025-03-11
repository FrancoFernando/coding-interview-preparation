# Description

ou are given an array prices where prices[i] is the price of a given stock on the ith day.

Find the maximum profit you can achieve. You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times) with the following restrictions:

After you sell your stock, you cannot buy stock on the next day (i.e., cooldown one day).
Note: You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).

 

Example 1:

Input: prices = [1,2,3,0,2]
Output: 3
Explanation: transactions = [buy, sell, cooldown, buy, sell]
Example 2:

Input: prices = [1]
Output: 0
 

Constraints:

1 <= prices.length <= 5000
0 <= prices[i] <= 1000

# Thought Process

This is a dynamic programming problem: we need to try all the possible combinations of buying and selling stocks and subproblems overlap.

At any given day, we can be in one of two states:
a) Holding a stock
b) Not holding a stock

If we're holding a stock, we can:
a) Continue holding it
b) Sell it (and jump the next day)
If we're not holding a stock, we can:
a) Continue not holding
b) Buy a stock

The top-down recursive solution uses the following structure:

- index (current day)
- canBuy (boolean indicating if we can buy a stock)

At each step (day) you can decide if do nothing or sell/buy. After we sell we skip two indexes.

The bottom-up solution uses the following recurrence:

hold[i] = max(hold[i-1], notHold[i-1] - prices[i],)
notHold[i] = max(notHold[i-1], hold[i-1] + prices[i])

where

hold[i]: Maximum profit on day i if we're holding a stock
notHold[i]: Maximum profit on day i if we're not holding a stock
