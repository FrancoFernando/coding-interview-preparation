# Description

You have some apples and a basket that can carry up to 5000 units of weight.

Given an integer array weight where weight[i] is the weight of the ith apple, return the maximum number of apples you can put in the basket.

 

Example 1:

Input: weight = [100,200,150,1000]
Output: 4
Explanation: All 4 apples can be carried by the basket since their sum of weights is 1450.
Example 2:

Input: weight = [900,950,800,1000,700,800]
Output: 5
Explanation: The sum of weights of the 6 apples exceeds 5000 so we choose any 5 of them.
 

Constraints:

1 <= weight.length <= 103
1 <= weight[i] <= 103

# Thought process

To maximize the number of apple we need to pick the ones with minor weight first. Sorting the inout array is how to do it.

# Complexity

The time complexity is O(n log n) due to the sorting operation, where n is the number of apples. 
The space complexity is O(1) as we're not using any additional data structures that scale with the input size.
