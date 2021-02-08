# Thinking Process 

1. To implement the peak it is necessary to cache the value returned by next before it is called.

2. Peek return the cached value.

3. Next return the cached value and update it with the next cached value (if any).

4. hasNext says if there is a value after the cached one. A boolean flag it is necessary to know if the values are not finished. 

# Complexity (approach 1)

* O(1) time
* O(1) space






