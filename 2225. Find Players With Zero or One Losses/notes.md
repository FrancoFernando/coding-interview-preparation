# Thinking Process 

The idea is to keep a map to count the number of lost matches for the losers and a set to keep track of the winners.
The list of all players that have not lost any matches are in winners but not in losers.
The list of all players that have lost exactly one match are all the losers with frequency 1.

# Complexity

* O(N) time to iterate through all the matches
* O(N) space to store set and map
