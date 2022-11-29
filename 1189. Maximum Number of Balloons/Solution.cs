public class Solution {
    public int MaxNumberOfBalloons(string text) {

        var char_frequencies = new int[26];
        var expected_frequencies = new int[26];

        foreach(var c in text) char_frequencies[c-'a']++;
        foreach(var c in "balloon") expected_frequencies[c-'a']++;

        int max_balloons = char_frequencies['b'-'a'];

        for (int c = 0; c < 26; ++c) {
            if (expected_frequencies[c] == 0) continue;
            max_balloons = Math.Min(max_balloons, char_frequencies[c]/expected_frequencies[c]);
        }
            

        return max_balloons;
    }
}
