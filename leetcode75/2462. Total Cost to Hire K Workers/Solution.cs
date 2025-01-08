public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        
        int left = 0, right = costs.Length - 1;
        var leftMinHeap = new PriorityQueue<int,int>();
        var rightMinHeap = new PriorityQueue<int,int>();

        for (; left < candidates; left++) {
            leftMinHeap.Enqueue(costs[left], costs[left]);
        }

        for (; right >= left && right >= costs.Length - candidates; right--) {
            rightMinHeap.Enqueue(costs[right], costs[right]);
        }

        long result = 0;

        while (k > 0) {
            int leftCost = leftMinHeap.TryPeek(out int cost, out _) ? cost : Int32.MaxValue;
            int rightCost = rightMinHeap.TryPeek(out cost, out _) ? cost : Int32.MaxValue;

            if (leftCost <= rightCost) {
                result += leftMinHeap.Dequeue();
                if (left <= right)  {
                    leftMinHeap.Enqueue(costs[left], costs[left]);
                    left++;
                }
            }
            else {
                result += rightMinHeap.Dequeue();
                if (left <= right) {
                    rightMinHeap.Enqueue(costs[right], costs[right]);
                    right--;
                }
            }
            k--;
        }
        return result;
    }
}
