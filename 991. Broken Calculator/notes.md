# Thinking Process 

1. BF is BFS. Think to numbers connected by edges based on operation.

2. Thinking from X point of view is too difficult. NEver know if it is better *2 or -1.
   Better thinking reverse from Y to X. *2 becomes /2 and -1 becomes +1. If current Y is odd we cannot divide, 
   otherwise we lose remainder information, so add 1. If current Y is even, divide is the fastest way to get X.
   

# Complexity (approach 1)

* O(logN) time, because we reduce by half every 1 or 2 steps.
* O(1) space






