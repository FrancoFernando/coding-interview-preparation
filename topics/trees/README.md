# Trees

## Overview

Trees are hierarchical data structures with a root node and child nodes forming a parent-child relationship. Each node has at most one parent.

## Key Concepts

- **Binary Tree**: Each node has at most 2 children
- **BST (Binary Search Tree)**: Left < Root < Right
- **Balanced Trees**: Height is O(log n) - AVL, Red-Black
- **Complete Binary Tree**: All levels filled except possibly last
- **Full Binary Tree**: Every node has 0 or 2 children

## Traversal Patterns

1. **Inorder (LNR)**: Left, Node, Right - gives sorted order for BST
2. **Preorder (NLR)**: Node, Left, Right - used for copying
3. **Postorder (LRN)**: Left, Right, Node - used for deletion
4. **Level Order (BFS)**: Level by level using queue

## Common Patterns

1. **Recursive DFS** - Most tree problems
2. **Iterative with Stack** - Simulate recursion
3. **BFS with Queue** - Level-order traversal
4. **Path Sum** - Track sum along paths
5. **LCA (Lowest Common Ancestor)** - Find common parent
6. **Tree Construction** - Build from traversals

## Time Complexities

| Operation (BST) | Average | Worst (unbalanced) |
|-----------------|---------|-------------------|
| Search | O(log n) | O(n) |
| Insert | O(log n) | O(n) |
| Delete | O(log n) | O(n) |

## Traversal Templates

```python
# Recursive inorder
def inorder(node):
    if not node:
        return
    inorder(node.left)
    process(node)
    inorder(node.right)

# Iterative inorder with stack
def inorder_iterative(root):
    stack, result = [], []
    current = root
    while stack or current:
        while current:
            stack.append(current)
            current = current.left
        current = stack.pop()
        result.append(current.val)
        current = current.right
    return result
```

## Notes

[Add your study notes here]
