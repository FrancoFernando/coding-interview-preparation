### Thinking Process

The problem asks two things: 1) calculate the next number 2) check if the next number has been already seen.
Thee first step can be done using a math modulo and division approach. 
The second step can be done using a hashset or the Floyd's Cycle-Finding Algorithm.

### Complexity

* Time complexity is O(logN) because each number has logN digits and no more than thos digits are processed.
  For a math prof just consider what happen calculating the maximum next number for each number of digits (i.e. 9, 99, 999 etc).
  The number of digits decreases.
  
* Space complexity is O(logN) for the hashset approach, O(1) for the Floyd's algorithm.
