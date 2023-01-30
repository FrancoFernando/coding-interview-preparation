### Thinking Process

The problem asks to find if a linked list holding integer values is a palindrome or not.

The brute force solution would be to copy the linked list values into an array and check if they're palindrome using the 2-pointer method. However, this solution's time and space complexity are O(N).

Recursion provides a more elegant solution with the same asymptotic complexity. The current node and its opposite are sent down to the recursion stack. When the function returns, the algorithm compares the current node to the opposite and advances the opposite. The opposite node shall be passed by reference so that its update returns from the recursion stack. Or it can be a global variable.

The following algorithm gives a more optimized solution in terms of space:

1. Find the middle of the list

2. Reverse the 2nd half of the list

3. Compare the two halves of the list

4. Restore the list as it was (if required)

### Complexity

* Time complexity is O(N)
* Space complexity is O(N) for the recursive and array solution and O(1) for the 3rd one

