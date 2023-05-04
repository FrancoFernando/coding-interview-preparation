## Thinking process

This is a simulation problem. The fact that senators will optimally use their power to help their party win suggests a greedy approach.
Intuitively the best move for a senator is to ban the next senator of the other party. How to simulate this efficiently?
Representing each senator with an index and putting senators into 2 queues. At each step 2 senator are dequeued and the one with lower index ban the other.
The winner is enqueued again (in a new queue or in the same with an inreased index not to ruin the processing order).

##

* O(N) time because each time some senators are not enqueued again
* O(N) space for the queue

