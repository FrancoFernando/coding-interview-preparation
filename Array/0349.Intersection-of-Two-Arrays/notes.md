### Thinking Process

The brute force solution is to iterate over the first array and for each element iterate over the second array to check if that element is there.
If it is it can be added to the intersection. A hash set would be necessary not to insert duplicates.

An alternative solution to avoid duplicates would be to sort both arrays and iterate through them with 2 pointers. 
The performance of this can be improved using binary search to check if an element of the 1st array is in the 2nd one.

A better solution is to store all element of the 1st array in a hash set and check if they are in the 2nd array. A clever trick can avoid duplicates.

### Complexity

* Time complexity is O(N+M)
* Space complexity is (O(N))
