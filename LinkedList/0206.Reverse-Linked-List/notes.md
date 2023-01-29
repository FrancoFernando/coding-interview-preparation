### Thinking Process

There are 2 approaches to solve this problem: iterative and recursive.

Iterative: the key is to think about what is necessary to do before reversing a link between 2 nodes A->B
0. Prev point to A and Curr point to B 1. The node next to B need to be saved 2. B points to A
3. Prev and Curr points to B and the node next to B

### Complexity

* Time cmplexity is O(N)
* Space complexity is O(1) for iterative and O(N) for recursive
