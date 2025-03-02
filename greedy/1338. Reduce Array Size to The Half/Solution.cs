public class Solution {
    public int MinSetSize(int[] arr) {

        var frequencies = new Dictionary<int, int>();
        foreach (int num in arr) {
            if (frequencies.ContainsKey(num)) {
                frequencies[num]++;
            } else {
                frequencies[num] = 1;
            }
        }

        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach (int freq in frequencies.Values) {
            pq.Enqueue(freq, freq);
        }

        int targetLength = arr.Length / 2;
        int remainingLength = arr.Length;
        int setSize = 0;

        while (remainingLength > targetLength) {
            remainingLength -= pq.Dequeue();
            setSize++;
        }
        
        return setSize;
    }
}
