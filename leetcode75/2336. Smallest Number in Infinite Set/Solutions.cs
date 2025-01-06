public class SmallestInfiniteSet {
    private SortedSet<int> addedNumbers;
    private int currentSmallest;

    public SmallestInfiniteSet() {
        addedNumbers = new SortedSet<int>();
        currentSmallest = 1;
    }
    
    public int PopSmallest() {
        if (addedNumbers.Count > 0) {
            int smallest = addedNumbers.Min;
            addedNumbers.Remove(smallest);
            return smallest;
        }
        return currentSmallest++;
    }
    
    public void AddBack(int num) {
        if (num < currentSmallest) {
            addedNumbers.Add(num);
        }
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */
