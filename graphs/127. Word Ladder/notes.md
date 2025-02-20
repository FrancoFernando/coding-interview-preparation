# Description

A transformation sequence from word beginWord to word endWord using a dictionary wordList is a sequence of words beginWord -> s1 -> s2 -> ... -> sk such that:

Every adjacent pair of words differs by a single letter.
Every si for 1 <= i <= k is in wordList. Note that beginWord does not need to be in wordList.
sk == endWord
Given two words, beginWord and endWord, and a dictionary wordList, return the number of words in the shortest transformation sequence from beginWord to endWord, or 0 if no such sequence exists.

 

Example 1:

Input: beginWord = "hit", endWord = "cog", wordList = ["hot","dot","dog","lot","log","cog"]
Output: 5
Explanation: One shortest transformation sequence is "hit" -> "hot" -> "dot" -> "dog" -> cog", which is 5 words long.
Example 2:

Input: beginWord = "hit", endWord = "cog", wordList = ["hot","dot","dog","lot","log"]
Output: 0
Explanation: The endWord "cog" is not in wordList, therefore there is no valid transformation sequence.
 

Constraints:

1 <= beginWord.length <= 10
endWord.length == beginWord.length
1 <= wordList.length <= 5000
wordList[i].length == beginWord.length
beginWord, endWord, and wordList[i] consist of lowercase English letters.
beginWord != endWord
All the words in wordList are unique.

# Thought Process

The problem can be seen as a graph problem. beginWord and endWord represent the start node and end node. The other nodes are defined in the wordList given to us. 

There is an edge between two words if they differ by just one letter.

We will essentially be working with an undirected and unweighted graph with words as nodes and edges between words which differ by just one letter. 
The problem reqires to find the shortest path from the start node to the destination node, if there exists one. Hence it can be solved using BFS.

An important step  is how to find adjacent nodes i.e. words which differ by one letter. 
To efficiently find them, we need to do some pre-processing on the words in the given list. 
The pre-processing involves replacing the letter of a word by a non-alphabet character and store them in a dictionary, so that we can quickly find for each word all the other reachable words.

# Complexity
