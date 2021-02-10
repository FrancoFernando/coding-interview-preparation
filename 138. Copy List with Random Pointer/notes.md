# Thinking Process 

1. Simplest solution is to clone the original list without random pointer. Store mapping between original and cloned nodes in an
  has table. Traverse the cloned list and link random pointers. 

2. An optimization to avoid use extra space could be interleaving original and cloned nodes, then link random pointers and then
   remove interleaving.

# Complexity (approach 1)

* O(N) time
* O(N) space for the hash table without optimization, O(1) space otherwise
 





