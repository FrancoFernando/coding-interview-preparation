# Thinking Process

1. Sorting each diagonal in place is too difficult. Better use another temporary structure where to
   store the elements of each diagonal, execute the sort there and then put the element back in their 
   original place.

# Complexity

* N = rows, M = cols
* O(NMlog(min(N,M))) time, since each element is accessed a costant number of times and the sort of a diagonal 
  costs min(N,M)log(min(N,M)). The max size of a diagonal is min(N,M).
* O(min(N,M)) space for the temporary structure


