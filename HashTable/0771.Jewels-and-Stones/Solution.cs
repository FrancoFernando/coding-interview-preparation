// Count after filtering jewels
public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        var jewelsSet = new HashSet<char>(jewels.ToCharArray());   
        return stones.Where(s => jewelsSet.Contains(s)).Count();
    }
}

// First count and then filter jewels (less efficient)
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
