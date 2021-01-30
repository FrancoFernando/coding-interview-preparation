# Thinking Process 

1. only two possible operations are allowed: *2 for odd numbers, /2 for even numbers.
   So odd numbers can only increase and even only decrease.
2. An odd number become even after first increasing, then can only come back to its original value
3. An even number become odd after x decreasing, then can only become odd or stay to its original value
4. From 2 and 3 -> the range of possible values to which each number can be transformed is FINITE
5. BF: iterate through all possible combination and keep the best one
6. DP: apply DP to avoid recomputation
7. we want to minimize MAX-MIN in the array: we can start from the minimum number in each range
   and try to minimize MAX-MIN increasing the minimum number among al ranges. When a ranges is exausted,
   we can stop because we reached the greater MIN and then MAX can only increase.
   
   Ex: [4,1,5,20,3] -> [1,1,5,5,3] -> [2,1,5,5,3] -> [2,2,5,5,3] -> [2,2,5,5,3]
# Complexity 

* Time complexity is O(m log n), where n is length of nums and m is total number of candidates, we can estimate it as m = O(n log K), where K is the biggest number. Finally, it will be O(n log n log K).
* Space complexity is O(n) for the heap






