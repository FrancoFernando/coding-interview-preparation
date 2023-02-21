public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        
        var decreasingNums = new Stack<int>();
        var numToGreater = new Dictionary<int,int>();

        foreach (int num in nums2) {

            while (decreasingNums.Count > 0 && decreasingNums.Peek() < num) {
                    numToGreater[decreasingNums.Pop()] = num;
            }
            decreasingNums.Push(num);
            numToGreater[num] = -1;
        }
        
        var ans = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; ++i) {
            ans[i] = numToGreater[nums1[i]];
        }
        return ans;
    }
}
