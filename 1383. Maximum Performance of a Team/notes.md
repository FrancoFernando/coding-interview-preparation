# Thinking Process 

1. The problem is needs to be carefully read to be understood. The maximum performance depends on two variables: the minimum efficiency in the team and the sum of the speed of the component. Once the engineer having minimum efficiency has been chosen, the performances is maximized picking the engineers with higher speed among the ones having greater efficiency. Repeating this for all the possible choices of engineer with minimum efficiency gives the solution. 

2. The optimal implementation relies on sorting the engineers for decreasing efficiency and analyzing them in this order. The speeds of the other team components can be obtained mantaining the k highest during the iteration. Both a min heap and a multiset are suitable for this. 

# Complexity 

* O(N(logN + logK)) time for the sorting and the priority queue update.
* O(N+K) space for the additional array sorted and the priority queue.






