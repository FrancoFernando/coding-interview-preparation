### Thinking process

The problem ask to find the index i such as the prefix sum of the element before i is equal to the postfix sum of the element after i.
At each step the postfix sum is equal to the sum of all the elements subtracted by the prefix sum up to i.
To optimize the solution in term of space observe that it's not necessary to precalculate the prefix sum of the whole array.
Mantaining 2 running counters for the prefix and postfiux sum is enough.

### Complexity

* The time complexity is O(N)
* The space complexity is O(1)
