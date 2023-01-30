### Thinking Process

This is just an implementation of the classic binary search algorithm on an array of integers.

The only thing to observe is the step computing the middle index between two indexes l and r.
Naively it is m = (r + l) / 2. To avoid overflow becomes l + (r-l) / 2.
This means that to the left index you add the half of the length of the range between l and r.

### Complexity

* TIme complexity is O(logN)

* Space complexity is O(1)
