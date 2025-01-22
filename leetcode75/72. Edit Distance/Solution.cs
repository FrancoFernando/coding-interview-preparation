public class Solution {

    private string _word1;
    private string _word2;
    private Dictionary<(int, int), int> _cache;

    public int MinDistance(string word1, string word2) {
        _word1 = word1;
        _word2 = word2;
        _cache = new Dictionary<(int, int), int>();
        return CalculateMinDistance(0, 0);
    }

    private int CalculateMinDistance(int i, int j) {

        if (i == _word1.Length) {
            return _word2.Length-j;
        }

        if (j == _word2.Length) {
            return _word1.Length-i;
        }

        if (_cache.TryGetValue((i,j), out int cachedResult)) {
            return cachedResult;
        }

        int result;
        if (_word1[i] == _word2[j]) {
            result = CalculateMinDistance(i+1, j+1);
        }
        else {
            int insert = CalculateMinDistance(i, j+1);
            int delete = CalculateMinDistance(i+1, j);
            int replace = CalculateMinDistance(i+1, j+1);
            result = 1 + Math.Min(replace, Math.Min(insert, delete));
        }
        _cache[(i,j)] = result;
        return result;
    }
}
