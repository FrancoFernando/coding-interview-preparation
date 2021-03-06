# Thinking Process 

1. If a word is a suffix of another word, it should not be taken into account for the encoding. After inserting backward all the words in a Trie, it would be easy to ignore them. The only words to be counted are the ones corresonding to the leaves. So performing bfs and counting the leaves and their depth, will give the answer.

# TODO 

Explore the possibiliy to do one pass without DFS. It is certainlt possible. Implement Trie with smartpointers.

# Complexity 

* O(W) time, where W is the number of chars in all words
* O(W) space to store all chars of all words






