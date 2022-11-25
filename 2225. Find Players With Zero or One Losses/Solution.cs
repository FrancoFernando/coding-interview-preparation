public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {
        
        var losers = new Dictionary<int,int>();
        var winners = new HashSet<int>();
        
        foreach (var match in matches) {
            winners.Add(match[0]);
            losers.TryGetValue(match[1], out int lostMatches);
            losers[match[1]] = lostMatches + 1;
        }
        

        var notLostAnyMatch = new List<int>();
        foreach (var team in winners) {
            if (!losers.ContainsKey(team)) notLostAnyMatch.Add(team);
        }

        var lostExactlyOneMatch = new List<int>();
        foreach (var (team, lostMatches) in losers) {
            if (lostMatches == 1) lostExactlyOneMatch.Add(team);
        }

        notLostAnyMatch.Sort();
        lostExactlyOneMatch.Sort();

        return new List<IList<int>>(){ notLostAnyMatch, lostExactlyOneMatch };
    }
}
