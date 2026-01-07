# Searching

## Overview

Searching algorithms find elements or positions within data structures. Binary search is the most important technique for interviews.

## Key Concepts

- **Linear Search**: O(n) scan through all elements
- **Binary Search**: O(log n) on sorted data
- **Search Space Reduction**: Halving possibilities each iteration

## Binary Search Patterns

1. **Classic Binary Search** - Find exact element
2. **Lower/Upper Bound** - First/last occurrence
3. **Search in Rotated Array** - Modified binary search
4. **Search on Answer** - Binary search on result space
5. **Peak Finding** - Find local maximum

## Binary Search Template

```python
def binary_search(arr, target):
    left, right = 0, len(arr) - 1
    while left <= right:
        mid = left + (right - left) // 2
        if arr[mid] == target:
            return mid
        elif arr[mid] < target:
            left = mid + 1
        else:
            right = mid - 1
    return -1  # not found

# Lower bound (first >= target)
def lower_bound(arr, target):
    left, right = 0, len(arr)
    while left < right:
        mid = left + (right - left) // 2
        if arr[mid] < target:
            left = mid + 1
        else:
            right = mid
    return left
```

## Time Complexities

| Algorithm | Time |
|-----------|------|
| Linear Search | O(n) |
| Binary Search | O(log n) |
| Ternary Search | O(log n) |

## Notes

[Add your study notes here]
