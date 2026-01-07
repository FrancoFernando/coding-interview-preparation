# Arrays

## Overview

Arrays are contiguous blocks of memory that store elements of the same type. They provide O(1) random access but O(n) insertion/deletion in the middle.

## Key Concepts

- **Indexing**: O(1) access by index
- **Two Pointers**: Using two indices to traverse from different ends
- **Sliding Window**: Maintaining a window of elements for subarray problems
- **Prefix Sum**: Precomputing cumulative sums for range queries
- **In-place Modifications**: Modifying arrays without extra space

## Common Patterns

1. **Two Pointers** - Converging from both ends or fast/slow pointers
2. **Sliding Window** - Fixed or variable size windows
3. **Binary Search** - On sorted arrays
4. **Kadane's Algorithm** - Maximum subarray sum
5. **Dutch National Flag** - Three-way partitioning

## Time Complexities

| Operation | Time |
|-----------|------|
| Access | O(1) |
| Search (unsorted) | O(n) |
| Search (sorted) | O(log n) |
| Insert/Delete (end) | O(1) |
| Insert/Delete (middle) | O(n) |

## Notes

[Add your study notes here]
