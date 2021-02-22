# Thinking Process 

1. The key observation is that knows(a,b) == 0 remove b from celebrity candidates because celebrity is known by all others. 
   In addition knows(a,b) == 1 remove a from celebrity candidates because celebrity doesn't know nobody. Using these rule we can remove all candidates except one. For this one we can again verify that the above rules are respected.

# Complexity (approach 1)

* O(N) asyntotic time. The call is executed only if both a,b are still candidates and every call remove one candidate.
* O(N) space






