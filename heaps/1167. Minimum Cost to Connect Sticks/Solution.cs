public class Solution {
    public int ConnectSticks(int[] sticks) {
        
        var minHeap = new PriorityQueue<int, int>();
        foreach (var stick in sticks) {
            minHeap.Enqueue(stick, stick);
        }

        int totalCost = 0;
        while (minHeap.Count > 1) {
            int firstStick = minHeap.Dequeue();
            int secondStick = minHeap.Dequeue();
            int combinedStick = firstStick + secondStick;
            totalCost += combinedStick;
            minHeap.Enqueue(combinedStick, combinedStick);
        }

        return totalCost;
    }
}
