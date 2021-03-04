# Thinking Process 

1. Classic solution is with hashset. Store pointer to all node of a list in a hashset, run over the other list and stop at the first node that is in the set.  

2. To improve space complexity different solutions. Reverse both lists and run with two pointers untill they are equal, Mark all node of a list (i.e. with negative value if normally values are all positive), then run over the other list and sto at the firt marked node. The most subtle solution is based on the observation that, if there is an intersection, the last part is in common between the two list and that the length f this last part can't be more of the length than the shortest list. So use two pointers one starting at the beginning of the shortest list, one advancing the head of the longest list by the difference between the lengths of the two list. Advance the pointers until they do not point the same node. This last approch is related to the first one, but there is no need to reverse the lists.

# Complexity (approach 1)

* O(N) time
* O(N) space for the hash set






