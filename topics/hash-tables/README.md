# Hash Tables

## Overview

Hash tables (dictionaries, maps) provide average O(1) lookup, insertion, and deletion by mapping keys to values through a hash function.

## Key Concepts

- **Hash Function**: Maps keys to bucket indices
- **Collision Resolution**: Chaining or open addressing
- **Load Factor**: Ratio of elements to buckets
- **Rehashing**: Resizing when load factor exceeds threshold

## Common Patterns

1. **Frequency Counting** - Count occurrences of elements
2. **Two Sum Pattern** - Store complements for O(1) lookup
3. **Grouping/Anagrams** - Group by canonical form
4. **Caching/Memoization** - Store computed results
5. **Set Operations** - Intersection, union, difference

## Time Complexities

| Operation | Average | Worst |
|-----------|---------|-------|
| Insert | O(1) | O(n) |
| Delete | O(1) | O(n) |
| Search | O(1) | O(n) |

## Python Tips

```python
# defaultdict for cleaner counting
from collections import defaultdict, Counter

# Counter for frequency
freq = Counter(arr)

# defaultdict for grouping
groups = defaultdict(list)
```

## Notes

[Add your study notes here]
