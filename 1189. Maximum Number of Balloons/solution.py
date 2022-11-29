class Solution:
    def maxNumberOfBalloons(self, text: str) -> int:

        char_frequencies = collections.Counter(text)
        expected_frequencies = collections.Counter('balloon')

        max_balloons = char_frequencies['b']

        for char in expected_frequencies.elements():
            max_balloons = min(max_balloons, char_frequencies[char]//expected_frequencies[char])

        return max_balloons
