# Thinking Process 

Brute force is to use an hash set to store all the existing numbers. Then iterate from 1:n and add the ones not in the set to the output.
If we're allowed to change the input array the space can be optimized marking the existing numbers there. 
Since all numbers are positives, the marker is making the existing ones negatives.

# Complexity

* O(N) time to iterate through the input
* O(1) space
