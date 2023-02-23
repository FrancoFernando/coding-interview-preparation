### Thinking Process

The problem ask to find the next greater element for each element af a given subarray.
The brute force solution is to search each greater element iterating through the array.
The time complexity of this solution is quadratic. 
A better solution is iterating through the array inserting its element in a decreasing monotonic stack.
Such stack contains only elements in decreasing order. 
When a greater element x comes, all the element lower then x are popped out frome the stack and x is pushed.
The pushed element is the greater element for all the popped element. 
The correspondences between each element and its greater can be convinently.stored in a hash map to build up the requested result.

### Time complexity

* The time complexity is O(N) because each element is pushed in and popped out of the stack only once.
* The space complexity is O(N) for the stack
