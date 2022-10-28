# Thinking Process 

Brute force would be to use an extra array to copy elements, but it's required to do without extra memory.
The key observation is noticing that if we know the number of 0 on the left of an element, we know the final position of the element.
So it can be solved in two steps.
1. Count the number of zeros
2. Walking backwards through the array copying the element in their final position (adding a check not to write out of the array.
 

# Complexity (approach 1)

* O(N) time to iterate through the array twice
* O(1) space
