### Thinking Process

The problem can be solved using the 2 pointers method to iterate the input string from left and right.
There are only 2 things to consider:
- strings are immutable in some languages (C# use string.create, tochararray or stringbuilder)
- carefuly do checks while moving pointers not to have index out of bound

### Complexity

* O(N) time
* O(1) space 
