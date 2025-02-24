public class Solution {
    public int FindKthLargest(int[] nums, int k) {

        PriorityQueue<int, int> pq = new();  //MinHeap by default

        for (int i = 0; i < k; ++i) {
            pq.Enqueue(nums[i],nums[i]);
        }

        for (int i = k; i < nums.Length; ++i) {
            if (nums[i] > pq.Peek()) { //keep the k largest in the min heap
                pq.Dequeue();
                pq.Enqueue(nums[i],nums[i]);
            }
        }
        return pq.Peek();
    }
}
