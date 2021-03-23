# Thinking Process 

1. Adapt 3sum problem. Sort the input, fix a number and solve a 2sum. When a two sum target has been found there are two cases. If the two values are equal, the first can be paired with all after the first one, the second can be paired with all after the second one, and so on -> add all these pairs to the answer. If the two values are different, the number of pairs to add corresponds to the cross product of their occurrences.

# Complexity (approach 1)

* O(N^2) time to fix an element and iterate over the other pairs (sorting is neglectible)
* O(1) space 






