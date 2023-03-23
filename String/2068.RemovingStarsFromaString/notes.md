### Thinking Process

The problem takes as input a string s, which contains stars. The goal is to remove for each star the closest non-star character to its left and the star itself.
The best way to approach the problem is to build the output string manually. We can iterate over the input string, and process a single character each time. We put the character in the output string if it is not a star. If the character is a star we remove the last inserted character without placing the star in.
This sounds like a LIFO behavior we could get using an array. We could explicitly use a stack data structure or simulate the stack behavior while building the output string.

### Complexity

* The time complexity of the solution is O(N), because we iterate over the whole input. 
* The space complexity is O(1) because we build directly the solution without using extra space. 
