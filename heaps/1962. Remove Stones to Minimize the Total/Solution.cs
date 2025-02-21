public class Solution {
    public int MinStoneSum(int[] piles, int k) {
        
        var maxHeap = new PriorityQueue<int,int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        for (int i = 0; i < piles.Length; i++) {
            maxHeap.Enqueue(i, piles[i]);
        }

        for (; k > 0; k--) {
            var index = maxHeap.Dequeue();
            piles[index] -= piles[index] / 2;
            maxHeap.Enqueue(index, piles[index]);
        }
        return piles.Sum();
    }
}

// optimization without changing the input array
public class Solution {
    public int MinStoneSum(int[] piles, int k) {
        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        int totalStones = 0;

        foreach (int pile in piles) {
            maxHeap.Enqueue(pile, pile);
            totalStones += pile;
        }

        while (k > 0 && maxHeap.TryDequeue(out int maxPile, out _)) {
            int removed = maxPile / 2;
            totalStones -= removed;
            int newPile = maxPile - removed;
            
            if (newPile > 0) {
                maxHeap.Enqueue(newPile, newPile);
            }
            
            k--;
        }

        return totalStones;
    }
}
