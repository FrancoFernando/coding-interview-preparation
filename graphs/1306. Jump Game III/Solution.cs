public class Solution {
    public bool CanReach(int[] arr, int start) {
        var queue = new Queue<int>();
        int length = arr.Length;
        var visited = new bool[length];

        queue.Enqueue(start);
        visited[start] = true;

        while (queue.Count > 0) {
            int index = queue.Dequeue();
            if (arr[index] == 0) return true;

            int[] nextIndices = { index + arr[index], index - arr[index] };
            foreach (int nextIndex in nextIndices) {
                if (nextIndex >= 0 && nextIndex < length && !visited[nextIndex]) {
                    queue.Enqueue(nextIndex);
                    visited[nextIndex] = true;
                }
            }
        }
        return false;
    }
}
