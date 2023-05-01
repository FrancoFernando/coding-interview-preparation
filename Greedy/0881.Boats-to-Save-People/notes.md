## Thinking process

The problem takes as input a list of people's weights and some boats with a maximum capacity. The goal is to find the minimum number of boats required to save all the people, given the following constraints:

that each boat can only carry maximum two people

the weight of the people in a boat shall not exceed its capacity.

This classic optimization problem can be solved using a greedy algorithm. Greedy algorithms work by making the best possible choice at each step, hoping that these choices will lead to an optimal solution.

For this particular problem, the key is to sort the list of people's weights in descending order. Once the list is sorted, we can make the optimal choice by picking the heaviest and lightest people each time. Only the heaviest is picked if their weight exceeds the boat's capacity.

## Complexity

* Time complexity is O(NlogN) to sort the input array
* Space complexity is O(1)
