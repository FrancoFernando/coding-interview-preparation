### Thinking Process

The brute force solution would be to copy the linked list value into an array and check if they're palidrome using 2 pointers.

A more elegant solution is given by recursion. Both current node and its nopposite are sent down to the recursion stack.
When the function returns the current node is compared to the opposite and the opposite and the opposite advances.
The opposite node shall be passed by reference so that it's update returning back from the recursion stack.
Or it can be a global vartiable.

A more optimiized solution in term of space is given by 3 step:

1. Find the middle of the list
2. Reverse the 2nd half of the list
3. compare the 2 halves of the list
4. restore the list as it was

### Complexity

* Time complexity is O(N)
* Space complexity is O(N) for the recursive and array solution and O(1) for the 3rd one

