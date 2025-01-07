public class Solution {
    public long MaxScore(int[] nums1, int[] nums2, int k) {

        int n = nums1.Length;
        var pairs = new (int num1, int num2)[n];
        for (int i = 0; i < n; i++) {
            pairs[i] = (nums1[i], nums2[i]);
        }

        Array.Sort(pairs, (a, b) => b.num2.CompareTo(a.num2));

        var minHeap = new PriorityQueue<int, int>();
        long sumNums1 = 0, result = 0;
        for (int i = 0; i < n; i++)
        {
            if (i < k)
            {
                minHeap.Enqueue(pairs[i].Item1, pairs[i].num1);
                sumNums1 += pairs[i].num1;
                if (i == k - 1) {
                    result = sumNums1 * pairs[i].num2;
                }
            }
            else {
                sumNums1 = sumNums1 - minHeap.Dequeue() + pairs[i].num1;
                result = Math.Max(result, pairs[i].num2 * sumNums1);
                minHeap.Enqueue(pairs[i].num1, pairs[i].num1);
            }
        }

        return result;
    }
}

// Top k elements seen sofar of nums1
// to maximize new min remove the minimum of nums 1
