public class Solution {
    public int[][] KClosest(int[][] points, int k) {

        var maxHeap = new PriorityQueue<int[], double>(k, Comparer<double>.Create((a, b) => b.CompareTo(a)));

        foreach (var point in points) {
            double distanceSquared = point[0] * point[0] + point[1] * point[1];
            if (maxHeap.Count < k) {
                maxHeap.Enqueue(point, distanceSquared);
            } else if (maxHeap.TryPeek(out _, out double priority) && distanceSquared < priority) {
                maxHeap.Dequeue();
                maxHeap.Enqueue(point, distanceSquared);
            }
        }

        return maxHeap.UnorderedItems.Select(item => item.Element).ToArray();
    }
}
