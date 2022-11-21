// Hash Table: linear space
public class Solution {
    public int MissingNumber(int[] nums) {
        
        HashSet<int> uniqueNums = new HashSet<int>(nums); 
        for (int i = 0; i < nums.Length; ++i) {
            if(!uniqueNums.Contains(i)) return i;
        }
        return nums.Length;
    }
}

// Xor: constant space
public class Solution {
    public int MissingNumber(int[] nums) {
        
        int missingNumber = nums.Length;
        for (int i = 0; i < nums.Length; ++i) {
            missingNumber ^= nums[i]^i;
        }
        return missingNumber;
    }
}
