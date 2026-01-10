# Backtracking

## Overview

Backtracking is an algorithmic technique for solving problems recursively by building candidates to the solution incrementally and abandoning candidates ("backtracking") when they fail to satisfy constraints.

## Key Concepts

- **State Space Tree**: Tree of all possible states/decisions
- **Pruning**: Eliminating branches that cannot lead to valid solutions
- **Choice/Constraint/Goal**: The three components of backtracking problems
- **Incremental Construction**: Building solutions one step at a time

## Common Patterns

1. **Subsets/Power Set** - Include or exclude each element
2. **Permutations** - Arrange elements in all possible orders
3. **Combinations** - Select k elements from n
4. **Partitioning** - Divide into groups meeting criteria
5. **Grid Search** - Find paths or patterns in 2D grids
6. **Constraint Satisfaction** - N-Queens, Sudoku

## Backtracking Template

```python
def backtrack(state, choices):
    # Goal: Check if current state is a valid solution
    if is_goal(state):
        result.append(state.copy())
        return

    # Iterate through all possible choices
    for choice in choices:
        # Constraint: Skip invalid choices (pruning)
        if not is_valid(choice):
            continue

        # Make choice
        state.append(choice)

        # Recurse with updated state
        backtrack(state, remaining_choices)

        # Undo choice (backtrack)
        state.pop()
```

## Time Complexity

Most backtracking problems have exponential time complexity:
- Subsets: O(2^n)
- Permutations: O(n!)
- Combinations: O(C(n,k))

## Tips

1. **Sort first** when dealing with duplicates to skip them easily
2. **Use index parameter** to avoid revisiting previous elements
3. **Pass by reference** and undo changes rather than creating copies
4. **Prune early** to improve performance

## Notes

[Add your study notes here]
