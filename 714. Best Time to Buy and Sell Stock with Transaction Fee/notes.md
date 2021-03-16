# Thinking Process 

1. Considering a day d:
* if we don't have a stock we can decide to buy a stock with price prices[d] or not buy
* if we have a stock we can decide to sell a stock with price prices[d]-fee or not sell
First of all we need a way to understand if we have or not a stock -> simpler is bool flag.
Other observation is that fee can be applied either buying (prices[d]+fee) or selling (prices[d]-fee. Let's go back to case 1: 
* if we buy a stock the max gain we can get is -(prices[d]+fee) + do transaction with flag sell
* if we sell a stock the max gain we can get is (prices[d]) + do transaction with flag buy

# TODO

Bottom up dp, with optimized O(1) space. Greedy?

# Complexity (approach 1)

* O(N) time 
* O(N) space for the dp cache.






