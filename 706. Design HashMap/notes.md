# Thinking Process 

1. Implementation with chaining. Number of buckets chosen as prime number. Size so that number of buckets / number of possible insert is 0.4. 

# Complexity (approach 1)

* O(N/K) time for each operation, where N = possible inserted keys and K = number of buckets. Assuming the hash function uniformely distribute the keys, each bucket contain N/K element. Accessing a bucket is O(1) so in the worst case it is necessary to iterate through all the N/K elements of each bucket.
* O(K+N) space for the K buckets containg the N possible key-value pairs.






