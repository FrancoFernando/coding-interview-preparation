"""
LeetCode #1832: Check if the Sentence Is Pangram
Difficulty: Easy
Link: https://leetcode.com/problems/check-if-the-sentence-is-pangram/
"""


class Solution:
    def checkIfPangram(self, sentence: str) -> bool:
        return len(set(sentence)) == 26


def test_solution():
    sol = Solution()
    assert sol.checkIfPangram("thequickbrownfoxjumpsoverthelazydog") == True
    assert sol.checkIfPangram("leetcode") == False
    print("All tests passed!")


if __name__ == "__main__":
    test_solution()
