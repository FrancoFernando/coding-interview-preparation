public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        var stonesFrequency = new Dictionary<char,int>();
        foreach (var stone in stones) {
            if(!stonesFrequency.TryGetValue(stone, out var value)) {
                stonesFrequency.Add(stone,0);
            }
            stonesFrequency[stone]++;
        }
        
        var jewelsInStones = stonesFrequency.Keys.Intersect(jewels);
        var jewelsFrequency = jewelsInStones.ToDictionary(t => t, t => stonesFrequency[t]);
        
        return jewelsFrequency.Sum(j => j.Value);
    }
}
