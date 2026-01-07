# Sorting

## Overview

Sorting algorithms arrange elements in a specific order. Understanding their trade-offs is crucial for choosing the right algorithm.

## Key Concepts

- **Comparison-based**: Compare elements (lower bound O(n log n))
- **Non-comparison**: Counting, radix, bucket sort
- **Stability**: Preserves relative order of equal elements
- **In-place**: Uses O(1) extra space

## Common Algorithms

| Algorithm | Time (Avg) | Time (Worst) | Space | Stable |
|-----------|------------|--------------|-------|--------|
| Quick Sort | O(n log n) | O(n²) | O(log n) | No |
| Merge Sort | O(n log n) | O(n log n) | O(n) | Yes |
| Heap Sort | O(n log n) | O(n log n) | O(1) | No |
| Insertion Sort | O(n²) | O(n²) | O(1) | Yes |
| Counting Sort | O(n + k) | O(n + k) | O(k) | Yes |

## Common Patterns

1. **Custom Comparators** - Sort by specific criteria
2. **Partial Sorting** - Find k-th element (Quick Select)
3. **Merge Intervals** - Sort then merge overlapping
4. **Meeting Rooms** - Sort by start/end times
5. **Dutch National Flag** - 3-way partition

## Python Tips

```python
# Custom sort key
arr.sort(key=lambda x: x[1])

# Sort by multiple criteria
arr.sort(key=lambda x: (x[0], -x[1]))

# Stable sort preserves order
arr.sort()  # Timsort is stable
```

## Notes

[Add your study notes here]
