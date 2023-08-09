### Thinking process

Deleting a key k is an operation based on a search. There are 3 possibilities:

1. k has no children and can be deleted

2. k has 1 child that need to be linked to the parent of k

3. k has 2 children and need to be first swapped with its successor and then deleted. The deletion is trivial because after the swapping k has either no children or one child. 

### Complexity

* Time complexity is O(H) where H is the tree height
* Space complexity is O(H) for the recursion stack