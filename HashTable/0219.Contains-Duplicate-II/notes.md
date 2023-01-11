### Thinking process

The brute force solution is to mantain a sliding windows comparing each number in the windows with all the others.
The optimal solution is to use a hash set to mantain all numbers in the windows.
At each step a new number is checked against the set and the last element in the window is removed from the set.

### Complexity

* Time complexity is O(N) to iterate the input array
* Space complexity is O(K) for the hash set
