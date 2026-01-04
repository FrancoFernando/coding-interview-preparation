#!/usr/bin/env python3
"""
Generate category indexes and update README from metadata.json
Run this after adding new problems or updating metadata
"""

import json
from collections import defaultdict
from pathlib import Path
from datetime import datetime


def load_metadata():
    """Load metadata from JSON file"""
    metadata_path = Path(__file__).parent.parent / "metadata.json"
    with open(metadata_path, 'r') as f:
        return json.load(f)


def generate_category_indexes(data):
    """Generate markdown files for each category"""
    # Group problems by category
    by_category = defaultdict(lambda: defaultdict(list))
    
    for problem in data['problems']:
        for category in problem['categories']:
            by_category[category][problem['difficulty']].append(problem)
    
    # Create categories directory
    categories_dir = Path(__file__).parent.parent / "categories"
    categories_dir.mkdir(exist_ok=True)
    
    # Generate individual category files
    for category, difficulties in sorted(by_category.items()):
        slug = category.lower().replace(' ', '-').replace('&', 'and')
        filename = categories_dir / f"{slug}.md"
        
        with open(filename, 'w') as f:
            f.write(f"# {category} Problems\n\n")
            f.write(f"[← Back to LeetCode](../README.md) | [← Back to Main](../../README.md)\n\n")
            
            total = sum(len(problems) for problems in difficulties.values())
            f.write(f"**Total: {total} problems**\n\n")
            
            # Write problems by difficulty
            for difficulty in ['Easy', 'Medium', 'Hard']:
                if difficulty in difficulties:
                    problems = sorted(difficulties[difficulty], key=lambda x: x['id'])
                    f.write(f"## {difficulty} ({len(problems)})\n\n")
                    
                    for p in problems:
                        # Get other categories
                        other_cats = [c for c in p['categories'] if c != category]
                        tags = f" · *{', '.join(other_cats)}*" if other_cats else ""
                        
                        # Build problem directory path
                        problem_slug = p['title'].lower().replace(' ', '-').replace("'", "")
                        problem_dir = f"problems/{p['id']:04d}-{problem_slug}"
                        
                        # Get available solutions
                        problem_path = Path(__file__).parent.parent / problem_dir
                        solutions = []
                        if (problem_path / "solution.py").exists():
                            solutions.append(f"[Python](../{problem_dir}/solution.py)")
                        if (problem_path / "solution.cpp").exists():
                            solutions.append(f"[C++](../{problem_dir}/solution.cpp)")
                        if (problem_path / "solution.java").exists():
                            solutions.append(f"[Java](../{problem_dir}/solution.java)")
                        
                        solutions_str = ", ".join(solutions) if solutions else "*No solution files*"
                        
                        f.write(f"### [{p['id']}. {p['title']}](../{problem_dir})\n\n")
                        if tags:
                            f.write(f"**Also in:** {tags[3:]}\n\n")
                        f.write(f"**Solutions:** {solutions_str}\n\n")
                        if p.get('notes'):
                            f.write(f"💡 *{p['notes']}*\n\n")
                        if p.get('time_complexity'):
                            f.write(f"⏱️ Time: {p['time_complexity']} | Space: {p.get('space_complexity', 'N/A')}\n\n")
                        f.write("---\n\n")
            
            f.write(f"*Last updated: {datetime.now().strftime('%Y-%m-%d')}*\n")
    
    # Generate category index
    with open(categories_dir / "README.md", 'w') as f:
        f.write("# All Categories\n\n")
        f.write("[← Back to LeetCode](../README.md) | [← Back to Main](../../README.md)\n\n")
        
        for category in sorted(by_category.keys()):
            slug = category.lower().replace(' ', '-').replace('&', 'and')
            total = sum(len(problems) for problems in by_category[category].values())
            easy = len(by_category[category].get('Easy', []))
            medium = len(by_category[category].get('Medium', []))
            hard = len(by_category[category].get('Hard', []))
            
            f.write(f"## [{category}]({slug}.md)\n\n")
            f.write(f"**{total} problems** · Easy: {easy} · Medium: {medium} · Hard: {hard}\n\n")
        
        f.write(f"\n---\n\n*Last updated: {datetime.now().strftime('%Y-%m-%d')}*\n")
    
    print(f"✅ Generated {len(by_category)} category files")


def update_leetcode_readme(data):
    """Update the LeetCode README.md with current stats"""
    problems = sorted(data['problems'], key=lambda x: x['id'])
    
    # Calculate stats
    stats = {
        'total': len(problems),
        'easy': len([p for p in problems if p['difficulty'] == 'Easy']),
        'medium': len([p for p in problems if p['difficulty'] == 'Medium']),
        'hard': len([p for p in problems if p['difficulty'] == 'Hard'])
    }
    
    easy_pct = (stats['easy'] / stats['total'] * 100) if stats['total'] > 0 else 0
    medium_pct = (stats['medium'] / stats['total'] * 100) if stats['total'] > 0 else 0
    hard_pct = (stats['hard'] / stats['total'] * 100) if stats['total'] > 0 else 0
    
    # Get all unique categories
    categories = sorted(set(cat for p in problems for cat in p['categories']))
    
    # Build README content
    content = f"""# LeetCode Solutions

Part of [coding-interview-preparation](../) repository.

![Problems Solved](https://img.shields.io/badge/solved-{stats['total']}-blue)
![Easy](https://img.shields.io/badge/easy-{stats['easy']}-green)
![Medium](https://img.shields.io/badge/medium-{stats['medium']}-yellow)
![Hard](https://img.shields.io/badge/hard-{stats['hard']}-red)

## 📊 Statistics

| Difficulty | Count | Percentage |
|------------|-------|------------|
| Easy       | {stats['easy']}     | {easy_pct:.1f}%       |
| Medium     | {stats['medium']}     | {medium_pct:.1f}%         |
| Hard       | {stats['hard']}     | {hard_pct:.1f}%         |
| **Total**  | **{stats['total']}** | -          |

## 🗂️ Browse by Category

Auto-generated category indexes:

"""
    
    for category in categories:
        slug = category.lower().replace(' ', '-').replace('&', 'and')
        content += f"- [{category}](categories/{slug}.md)\n"
    
    content += f"""- [View All Categories →](categories/)

## 🚀 Quick Actions

### Add New Problem
```bash
python scripts/new_problem.py <id> "<title>" [difficulty]

# Example:
python scripts/new_problem.py 42 "Trapping Rain Water" Hard
