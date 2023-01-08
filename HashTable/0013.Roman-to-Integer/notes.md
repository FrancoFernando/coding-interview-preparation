### Thinking process

The mapping between symbols and numbers needs to be encoded in a hash table.
Then the logicfor converting needs to be implemented. The easiest way is to proceed backward
and use the ebservation that a number needs to be subtracted only when greater than the next one.

### Complexity

* The time complexity is O(N) where N is the length of the input string
*  The space complexity is O(A) where A is the number of symbols 
