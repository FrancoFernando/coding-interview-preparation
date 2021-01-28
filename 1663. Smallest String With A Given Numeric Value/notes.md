# Thinking Process

1. Since the lexicographically smallest string is required, it makes sense to insert first the smallest letter and then the others. So first rule is to insert a until possible. When it is not possible anymore? After each insert of a, k=k-1 n=n-1 sand maxK = n*26. If k becomes greater than maxK it is not possible. At that point the best strategy is to insert that makes k multiple of 26 and then insert all z.

Example:
"aaszz" k = 73, n = 5, maxK = 130
- insert a: k = 72, n = 4, maxK = 104; 72 < 104 continue
- insert a: k = 71, n = 3, maxK = 78; 71 < 78 continue
- insert a: k = 70, n = 2, maxK = 52; 7 < 52 stop
- insert 71 % 26 = 19, n = 2
- insert z, n= 1
- insert z, n = 0

# Complexity

* O(N) time
* O(1) space 


