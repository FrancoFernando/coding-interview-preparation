# Coding Interview Preparation

Collection of solutions to coding problems and study resources for technical interview preparation.

## Platforms

- [LeetCode](leetcode/) - Solutions and stats

## Topics

Study notes and problem links organized by topic:

- [Arrays](topics/arrays/)
- [Dynamic Programming](topics/dynamic-programming/)
- [Graphs](topics/graphs/)
- [Hash Tables](topics/hash-tables/)
- [Linked Lists](topics/linked-lists/)
- [Searching](topics/searching/)
- [Sorting](topics/sorting/)
- [Trees](topics/trees/)

## Quick Start

### Add a new LeetCode problem
```bash
python3 leetcode/scripts/new_problem.py <id> "<title>" <difficulty> "<categories>"
# Example:
python3 leetcode/scripts/new_problem.py 1 "Two Sum" Easy "arrays,hash-tables"
```

### Regenerate indexes

```bash
# LeetCode category indexes
python3 leetcode/scripts/generate_indexes.py

# Topic problem lists (aggregates from all platforms)
python3 scripts/generate_topic_problems.py
```
