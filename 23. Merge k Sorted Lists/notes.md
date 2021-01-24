# Thinking Process 

1. Since all list are sorted, the first element of the output list is the lower between the first elements of all the list. Once this element has been inserted, the second element of the output list is the lower between the second element of the list from where the first one come and the first element of all the other lists. So we need a data structure to pick up each time the lower element -> min heap

2. Since each list is already sorted, we can think of each one of them as the base case of the merge sort. Merging all pair of lists will bring to the solution.

# Complexity (approach 1)

* O(Nlog(K) time, since the maximum size of the heap is K and each of the N insert/remove operations on the heap costs log(K)
* O(K) space for the heap






