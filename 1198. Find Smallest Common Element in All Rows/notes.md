# Thinking Process 

1. The key observation is that only the number present in a row (let's say the first) are candidate for the answer. So count the frequencies of these numbers in the other rows and return at the and the lower number having frequency equal to the number of row. The only thing to clarify is the existence of duplicates in a row (in this case no)

   

# Complexity (approach 1)

* O(NM) time.
* O(N) space to store the frequencies.






