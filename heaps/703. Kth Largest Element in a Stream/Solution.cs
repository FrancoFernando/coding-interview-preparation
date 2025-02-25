public class KthLargest {
    
    private readonly PriorityQueue<int, int> minHeap;
    private readonly int k;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        minHeap = new PriorityQueue<int,int>();
        foreach (int num in nums) {
            Add(num);
        }
    }
    
    public int Add(int val) {
        if (minHeap.Count < k) {
            minHeap.Enqueue(val, val);
        } else if (val > minHeap.Peek()) {
            minHeap.Enqueue(val, val);
            minHeap.Dequeue();
        }

        return minHeap.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
