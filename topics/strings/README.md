# Strings

## Overview

Strings are sequences of characters. In Python, strings are immutable, meaning operations create new strings rather than modifying in place.

## Key Concepts

- **Immutability**: Strings cannot be modified after creation
- **Indexing/Slicing**: O(1) access, O(k) for slices
- **StringBuilder Pattern**: Use list + join for efficient concatenation
- **ASCII/Unicode**: Character encoding and ord()/chr() functions

## Common Patterns

1. **Two Pointers** - Palindrome checking, reversal
2. **Sliding Window** - Substring problems, anagrams
3. **Hash Map** - Character frequency, anagram grouping
4. **String Matching** - KMP, Rabin-Karp algorithms
5. **Trie** - Prefix matching, autocomplete

## Time Complexities

| Operation | Time |
|-----------|------|
| Access by index | O(1) |
| Slice | O(k) |
| Concatenation | O(n + m) |
| Search substring | O(n * m) naive, O(n + m) KMP |
| Compare | O(min(n, m)) |

## Python Tips

```python
# Efficient string building
parts = []
for item in items:
    parts.append(str(item))
result = ''.join(parts)

# Character frequency
from collections import Counter
freq = Counter(s)

# Check anagram
sorted(s1) == sorted(s2)
Counter(s1) == Counter(s2)

# Common string methods
s.lower(), s.upper(), s.strip()
s.split(), s.replace(), s.find()
s.isalpha(), s.isdigit(), s.isalnum()
```

## Notes

[Add your study notes here]
