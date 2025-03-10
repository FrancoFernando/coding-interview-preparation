# Description

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: s = "()"

Output: true

Example 2:

Input: s = "()[]{}"

Output: true

Example 3:

Input: s = "(]"

Output: false

Example 4:

Input: s = "([])"

Output: true

 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.

# Thought Process

You need to iterate over the input and check that for every closed bracket there is a correspondin open bracket.

A stack is the ideal data structure for that. 
Insert open bracket into the stack and when a closed bracket comes, check if the open bracket at the top of the stack is of the same type.
If at the end the stack is empty the expression is valid.

# Complexity

O(N) time and space
