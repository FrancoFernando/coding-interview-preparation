"""
LeetCode #93: Restore IP Addresses
Difficulty: Medium
Link: https://leetcode.com/problems/restore-ip-addresses/
"""
from typing import List


class Solution:
    MAX_OCTETS = 4
    MAX_OCTET_VALUE = 255

    def restoreIpAddresses(self, s: str) -> List[str]:
        result = []
        current = []
        self.backtrack(s, current, 0, result)
        return result

    def backtrack(self, s: str, current: List[str], octet: int, result: List[str]):
        if octet == self.MAX_OCTETS and not s:
            result.append(".".join(current))
            return

        # impossible to get a valid result
        if octet == self.MAX_OCTETS or not s:
            return

        current.append(s[0])
        self.backtrack(s[1:], current, octet + 1, result)
        current.pop()

        if len(s) >= 2 and self.is_valid_octet(s[:2]):
            current.append(s[:2])
            self.backtrack(s[2:], current, octet + 1, result)
            current.pop()

        if len(s) >= 3 and self.is_valid_octet(s[:3]):
            current.append(s[:3])
            self.backtrack(s[3:], current, octet + 1, result)
            current.pop()

    @staticmethod
    def is_valid_octet(octet: str) -> bool:
        if len(octet) > 1 and octet[0] == '0':
            return False
        return len(octet) > 0 and int(octet) <= Solution.MAX_OCTET_VALUE
