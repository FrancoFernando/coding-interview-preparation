#!/usr/bin/env python3
"""
Generate global statistics and update main README.md
Run this from the repository root after solving problems
"""

import json
from pathlib import Path
from datetime import datetime


def load_leetcode_metadata():
    """Load LeetCode metadata"""
    metadata_path = Path("leetcode/metadata.json")
    if metadata_path.exists():
        with open(metadata_path, 'r') as f:
            return json.load(f)
    return {"problems": []}


def calculate_stats(problems):
    """Calculate difficulty statistics"""
    stats = {
        'total': len(problems),
        'easy': len([p for p in problems if p['difficulty'] == 'Easy']),
        'medium': len([p for p in problems if p['difficulty'] == 'Medium']),
        'hard': len([p for p in problems if p['difficulty'] == 'Hard'])
    }
    return stats


def update_main_readme(leetcode_stats):
    """Update the main repository README.md"""
    
    total_stats = {
        'total': leetcode_stats['total'],
        'easy': leetcode_stats['easy'],
        'medium': leetcode_stats['medium'],
        'hard': leetcode_stats['hard']
    }
    
    # Build README content
    content = f"""# Coding Interview Preparation

Comprehensive collection of coding problems, solutions, and study resources for technical interview preparation.

![Total Problems](https://img.shields.io/badge/problems-{total_stats['total']}-brightgreen)
![LeetCode](https://img.shields.io/badge/LeetCode-{leetcode_stats['total']}-orange)
![Languages](https://img.shields.io/badge/languages-Python%20%7C%20C++-blue)

## 📊 Quick Stats

| Platform | Easy | Medium | Hard | Total |
|----------|------|--------|------|-------|
| [LeetCode](leetcode/) | {leetcode_stats['easy']} | {leetcode_stats['medium']} | {leetcode_stats['hard']} | {leetcode_stats['total']} |
| **Total** | **{total_stats['easy']}** | **{total_stats['medium']}** | **{total_stats['hard']}** | **{total_stats['total']}** |

## 🎯 Navigation

### 📚 By Platform
- **[LeetCode](leetcode/)** - Solutions organized by problem number and category

### 🧠 By Topic
- [Arrays](topics/arrays/)
- [Linked Lists](topics/linked-lists/)
- [Trees](topics/trees/)
- [Graphs](topics/graphs/)
- [Dynamic Programming](topics/dynamic-programming/)
- [Sorting & Searching](topics/sorting-searching/)
- [Hash Tables](topics/hash-tables/)
- [View All Topics →](topics/)

### 📖 Study Resources
- [Cheatsheets](resources/cheatsheets/) - Quick reference guides
- [Code Templates](resources/templates/) - Reusable patterns
- [Study Plans](study-plans/) - Blind 75, NeetCode 150

## 🚀 Quick Start

### Setup
```bash
cd coding-interview-preparation
