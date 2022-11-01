public class Solution {
    public bool CheckIfExist(int[] arr) {

        // Corner case 0*2 = 0
        if (arr.Count(n => n == 0) > 1) return true;
        
        HashSet<int> uniqueNumbers = new HashSet<int>(arr);

        foreach (int num in arr) {
            if (uniqueNumbers.Contains(num*2) && num != 0) {
                return true;
            }
        }
        return false;
    }
}
