# Thinking Process 

1. To efficiently check exact word match a hash set is enough.
2. To check capitalization, preprocess wordlist to get unique representation (i.e. all tolower). Then map each unique representation to the index in the input list
3.  To check vocals, again preprocess wordlist to get unique representation. In this case in addition to ransform all to lowercase is also necassary to replace all vocals with a marker (removing vocal is a mistake -> not unique representation).  

# Complexity (approach 1)

* O(N) time, where N are the input strings
* O(N) space 






