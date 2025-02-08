public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
        var result = new bool[candies.Length];
        int maxCandiesForKid = candies.Max();

        for(int i = 0; i < candies.Length; ++i){
            result[i] = (candies[i] + extraCandies >= maxCandiesForKid) ? true : false;
        }
        return result.ToList();
    }
}
