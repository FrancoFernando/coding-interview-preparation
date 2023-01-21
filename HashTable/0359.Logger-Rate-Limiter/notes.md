### Thinking Process

The most efficient way to implement the class is using a hash table to map messages to timestamp.
If a message is not in the table can be printed. If it is in the table can be printed only if the timestamp in the table is older by 10.
The timestamp in the table shall be updated only when a message is printed.

### Complexity

* O(N) time to check each message
* O(N) space to store messages in the hash table
