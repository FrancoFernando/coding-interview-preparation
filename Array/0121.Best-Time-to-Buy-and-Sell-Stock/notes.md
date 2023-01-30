### Thinking process

The problem asks to find the maximum profit you can achieve from a single transaction.
Prices are stored in an integers array sorted by time. So the selling price shall have an index j greater than the buying price i.

The brute force solution would be to try each selling price for each buying price and keep their maximum difference.
The time complexity would be O(N^2). But that's a lot of unnecessary work. 

A greedy approach leads to the optimal solution. While iterating through the array, keep and update the minimum buying price.
For each price, try to sell using that minimum buying price.
### Complexity 

* The time complexity is O(N)

* The space complexity is O(1)
