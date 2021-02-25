# Thinking Process 

1. Idea is to keep updated a windows delimiting the desidered subarray. Let's indicate with nMax the maximum number seen sofar. Every time the current number is lower than nMax the window needs to be updated. Certainly the end of the window would be the current number, but how about the start. The start is the minimum between the current start and the place where the current number would be placed if the array were sorted. If the current start is lower than the current number keep the current start, otherwise update start chosing the first number lower than the current number.

# Complexity (approach 1)

* O(N) time
* O(1) space 






