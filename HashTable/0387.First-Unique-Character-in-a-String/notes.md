### Thinking process

The brute force would be to check if each char in the input s is unique, returning the index of the first that is.

The optimized approach is to use a hash table to store the index of the first occurrence of a character.
This index is than marked as invalid in case of duplicated characters. The lower valid index is returned.

### Complexity

* Time complexity = O(N)
* Space complexity = O(1)
