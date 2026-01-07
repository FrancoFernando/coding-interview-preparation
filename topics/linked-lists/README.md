# Linked Lists

## Overview

Linked lists are sequential data structures where elements (nodes) contain data and pointers to next (and optionally previous) nodes.

## Key Concepts

- **Singly Linked**: Each node points to next
- **Doubly Linked**: Each node points to next and previous
- **Head/Tail**: First and last nodes
- **Dummy Node**: Sentinel node to simplify edge cases

## Common Patterns

1. **Two Pointers (Fast/Slow)** - Cycle detection, find middle
2. **Dummy Head** - Simplify insertion/deletion at head
3. **Reversal** - Iterative or recursive
4. **Merge** - Merge sorted lists
5. **Runner Technique** - Move pointers at different speeds

## Time Complexities

| Operation | Time |
|-----------|------|
| Access by index | O(n) |
| Insert at head | O(1) |
| Insert at tail | O(1) with tail pointer |
| Delete (given node) | O(1) |
| Search | O(n) |

## Common Techniques

```python
# Dummy head pattern
dummy = ListNode(0)
dummy.next = head
# ... operations ...
return dummy.next

# Fast/slow for cycle detection
slow = fast = head
while fast and fast.next:
    slow = slow.next
    fast = fast.next.next
    if slow == fast:
        return True  # cycle exists
```

## Notes

[Add your study notes here]
