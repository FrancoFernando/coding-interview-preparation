# Thinking Process 

1. We need to sort rows according to number of 1s, breaking ties according to row index. Max nmber of 1s is equal to number of cols.
   We can use radix sort with M bins where M is number of cols. We can process rows from first to last and put the index of the row in bin with the corresponding number of 1s. Since each row is sorted we can use binary search to find the last 1 in each row and then compute the number of 1s.

# Take aways

* Algorithms like find or lower_bound can be used also with reverse iterators.
* When using distance with a reverse iterator both need to be reverse iterator.
* Distance takes first, last as pair of iterators.

# Complexity (approach 1)

* O(Nlog(M)) time, where N = number of rows and M = number of cols. Each row is processed once to find number of 1s in log(M) thanks to binary search. An additional O(K) to build the answer.
* O(M) space for the bins.






