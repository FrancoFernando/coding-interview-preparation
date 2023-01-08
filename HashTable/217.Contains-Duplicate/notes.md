### Thinking process

The brute force solution is compare each number with all the others in O(N^2).
A better solution is sorting the input array and search for duplicates with a single iteration in O(NlogN)
The optimal solution is to use a hash set to check for duplicates in O(N).

### Complexity

* Time complexity is O(N) to iterate the input array
* Space complexity is O(N) for the hash set
