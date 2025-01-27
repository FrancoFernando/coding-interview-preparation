# Description 

You are given an array of strings products and a string searchWord.

Design a system that suggests at most three product names from products after each character of searchWord is typed. Suggested products should have common prefix with searchWord. If there are more than three products with a common prefix return the three lexicographically minimums products.

Return a list of lists of the suggested products after each character of searchWord is typed.

 

Example 1:

Input: products = ["mobile","mouse","moneypot","monitor","mousepad"], searchWord = "mouse"
Output: [["mobile","moneypot","monitor"],["mobile","moneypot","monitor"],["mouse","mousepad"],["mouse","mousepad"],["mouse","mousepad"]]
Explanation: products sorted lexicographically = ["mobile","moneypot","monitor","mouse","mousepad"].
After typing m and mo all products match and we show user ["mobile","moneypot","monitor"].
After typing mou, mous and mouse the system suggests ["mouse","mousepad"].
Example 2:

Input: products = ["havana"], searchWord = "havana"
Output: [["havana"],["havana"],["havana"],["havana"],["havana"],["havana"]]
Explanation: The only word "havana" will be always suggested while typing the search word.
 

Constraints:

1 <= products.length <= 1000
1 <= products[i].length <= 3000
1 <= sum(products[i].length) <= 2 * 104
All the strings of products are unique.
products[i] consists of lowercase English letters.
1 <= searchWord.length <= 1000
searchWord consists of lowercase English letters.

Thought Process:

This is a string search and prefix matching problem. It requires efficient retrieval of words with a common prefix.
Trie (Prefix Tree) is an excellent data structure for prefix-based operations.
Build a Trie with all products.
For each prefix of the search word, traverse the Trie and collect matching words.
Sort the matching words and take the top three.
Consider storing words directly in the Trie Nodes to avoid repeated search.
Consider using a data structure to keep the words sorted to simplify the code.

Complexity

Time Complexity:

- Insertion: O(L * log 3) for each word, where L is the word length.
- Overall building of Trie: O(N * L * log 3), where N is the number of products.
- Suggestion retrieval: O(M * 3), where M is the length of searchWord.
Space Complexity:
- O(N * L) in the worst case, but potentially more space-efficient due to the limit of 3 words per node.
