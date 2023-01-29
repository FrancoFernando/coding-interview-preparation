### Thinking Process

The idea is to reuse the seme procedure used to revere a whole linked list with a tweak.
The tweak is to save the two nodes necessary to attach the reversed part of the list to the non reversed one.

If the list is 1-2-3-4-5 and only the nodes 2,3,4 need to be reversed, the nides to save are 1 abd 5.
Creating a dummy node as head of the input list avoid to handle explicitly some corner cases.

### Complexity 

* Time complexity is O(N)
* Space complexity is O(1)
