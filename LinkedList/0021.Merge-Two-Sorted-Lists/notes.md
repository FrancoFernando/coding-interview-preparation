### Thinking Process

The easier way to merge the 2 lists is to create a 3rd list using a sentinel node.
The merge is done by iterating in parallel over the 2 input lists.
At each step, the node with the smaller value is appended to the 3rd list.
When one of the 2 input lists reaches its end, the other is appended to the 3rd list.

### Complexity

The time complexity is O(N+M), where N and M are the lengths of the input lists.

The space complexity is O(1)
