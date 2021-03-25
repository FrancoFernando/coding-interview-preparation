# Thinking Process 

1. A cell c can flow to both Pacific (P) and Atlantic (A) only if exists a decreasing path from c to a border cell marked with A or P. Check this property for every cell would be to expensive. A better way is to reverse the problem. A cell c can flow to both A and P if exists an increasing path from a border cell to c. This is better because the number of botter cell is less than the internal one and if a cell has been already marked that can flow to P (or A) it is possible to stop the process.

# TODO

Try BFS.

# Complexity 

* O(NM) time because each cell is visited only twice at maximum (once to mark as A and once as P)
* O(NM) space to save the mark for each cell






