#!/usr/bin/env python3
import json
import sys
from pathlib import Path
from datetime import datetime

TEMPLATE_README = """# {id}. {title}

**Difficulty:** {difficulty}  
**Link:** [LeetCode](https://leetcode.com/problems/{slug}/)

## Problem Description

[Paste problem description here]

## Approach

[Explain your approach]

## Complexity

- **Time Complexity:** O(?)
- **Space Complexity:** O(?)

## Notes

[Your notes]
"""

TEMPLATE_SOLUTION = """\"\"\"
LeetCode #{id}: {title}
Difficulty: {difficulty}
Link: https://leetcode.com/problems/{slug}/
\"\"\"

class Solution:
    def methodName(self):
        pass

def test_solution():
    sol = Solution()
    print("Add your tests here")

if __name__ == "__main__":
    test_solution()
"""

def get_slug(title):
    return title.lower().replace(' ', '-').replace("'", "").replace('"', '')

def create_problem(problem_id, title, difficulty="Medium"):
    slug = get_slug(title)
    dir_name = f"{problem_id:04d}-{slug}"
    base_dir = Path(__file__).parent.parent
    problem_dir = base_dir / "problems" / dir_name
    if problem_dir.exists():
        print(f"Problem already exists: {problem_dir}")
        return False
    problem_dir.mkdir(parents=True)
    readme_content = TEMPLATE_README.format(id=problem_id, title=title, difficulty=difficulty, slug=slug)
    (problem_dir / "README.md").write_text(readme_content)
    solution_content = TEMPLATE_SOLUTION.format(id=problem_id, title=title, difficulty=difficulty, slug=slug)
    (problem_dir / "solution.py").write_text(solution_content)
    metadata_path = base_dir / "metadata.json"
    with open(metadata_path, "r") as f:
        data = json.load(f)
    new_entry = {
        "id": problem_id,
        "title": title,
        "difficulty": difficulty,
        "categories": ["Array"],
        "link": f"https://leetcode.com/problems/{slug}/",
        "notes": "",
        "date_solved": datetime.now().strftime("%Y-%m-%d")
    }
    data["problems"].append(new_entry)
    data["problems"].sort(key=lambda x: x["id"])
    with open(metadata_path, "w") as f:
        json.dump(data, f, indent=2)
    print(f"Created: {problem_dir}")
    print(f"\nNext steps:")
    print(f"  1. Write solution in: {problem_dir}/solution.py")
    print(f"  2. Update categories in: metadata.json")
    print(f"  3. Run: python scripts/generate_indexes.py")
    return True

def main():
    if len(sys.argv) < 3:
        print("Usage: python new_problem.py <id> \"<title>\" [difficulty]")
        print("\nExamples:")
        print('  python new_problem.py 1 "Two Sum" Easy')
        print('  python new_problem.py 42 "Trapping Rain Water" Hard')
        sys.exit(1)
    problem_id = int(sys.argv[1])
    title = sys.argv[2]
    difficulty = sys.argv[3] if len(sys.argv) > 3 else "Medium"
    if difficulty not in ["Easy", "Medium", "Hard"]:
        print(f"Invalid difficulty: {difficulty}")
        print("Must be: Easy, Medium, or Hard")
        sys.exit(1)
    create_problem(problem_id, title, difficulty)

if __name__ == "__main__":
    main()
