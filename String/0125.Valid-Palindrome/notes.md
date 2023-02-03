### Thinking process

The problem could be easily solved with the 2 pointers method without the constraint of skipping non alphanumeric chars.

The easy solution is to create a reversed copy of the input string and compare this with the original string.

A better solution in terms of space is use the 2 pointers and be careful to out of index condition while skipping characters.

### COmplexity

* O(N) time
* O(1) space
