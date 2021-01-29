# Thinking Process

1. We need to count number of corners rectangle, so when 4 1s are corner rectangles? They needs to be axis aligned so:
* given two 1s on the same row at columns i and j, it must exists another row having 1s at the same columns
* or otherwise given two 1s on the same column at rows i and j, it must exists another column having 1s at the same rows
Top Down dp answer the question: for how many rectangles the pair of 1s i,j defines the topleft-topright corners?
Bottom up answer the question: for how many rectangles the pair of 1s i,j 
defines the bottomleft-bottomright corners?


# Complexity

* N = rows, M = cols
* O(M^2*N) time, since we search every pair of 1 in O(M^2) in each of the N rows
* O(M^2*N) space to cache occurrence of every pair in the rows with greater index

# TODO

Try to implement bottom up. Moreover a matrix with 0 and 1 suggest a possible bit manipulation approach.

