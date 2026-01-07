#!/usr/bin/env python3
"""
Generates problems.md files in topic folders by scanning all platform metadata.json files.
This aggregates problems from LeetCode, HackerRank, and other platforms by category.
"""
import json
from pathlib import Path
from datetime import datetime

# Base directory of the repository
BASE_DIR = Path(__file__).parent.parent
TOPICS_DIR = BASE_DIR / "topics"

# Platform configurations: (folder name, display name, metadata path relative to platform folder)
PLATFORMS = [
    ("leetcode", "LeetCode", "metadata.json"),
    ("hackerrank", "HackerRank", "metadata.json"),
    ("codeforces", "Codeforces", "metadata.json"),
]


def load_platform_metadata(platform_folder, metadata_file):
    """Load metadata.json from a platform folder if it exists."""
    metadata_path = BASE_DIR / platform_folder / metadata_file
    if not metadata_path.exists():
        return []
    with open(metadata_path, "r") as f:
        data = json.load(f)
    return data.get("problems", [])


def get_all_problems():
    """Load problems from all platforms."""
    all_problems = []
    for folder, display_name, metadata_file in PLATFORMS:
        problems = load_platform_metadata(folder, metadata_file)
        for problem in problems:
            problem["platform"] = display_name
            problem["platform_folder"] = folder
        all_problems.extend(problems)
    return all_problems


def get_topic_folders():
    """Get all topic folders that exist."""
    if not TOPICS_DIR.exists():
        return []
    return [d.name for d in TOPICS_DIR.iterdir() if d.is_dir() and not d.name.startswith('.')]


def group_problems_by_category(problems):
    """Group problems by their categories."""
    by_category = {}
    for problem in problems:
        for category in problem.get("categories", []):
            if category not in by_category:
                by_category[category] = []
            by_category[category].append(problem)
    return by_category


def get_problem_path(problem):
    """Get the relative path to the problem solution."""
    platform_folder = problem.get("platform_folder", "leetcode")
    problem_id = problem.get("id", 0)
    title = problem.get("title", "unknown")
    slug = title.lower().replace(' ', '-').replace("'", "").replace('"', '')
    return f"{platform_folder}/problems/{problem_id:04d}-{slug}/solution.py"


def generate_problems_md(topic, problems):
    """Generate the problems.md content for a topic."""
    lines = [
        f"# {topic.replace('-', ' ').title()} Problems",
        "",
        f"_Last updated: {datetime.now().strftime('%Y-%m-%d')}_",
        "",
    ]

    if not problems:
        lines.append("No problems linked to this topic yet.")
        return "\n".join(lines)

    # Group by platform
    by_platform = {}
    for problem in problems:
        platform = problem.get("platform", "Unknown")
        if platform not in by_platform:
            by_platform[platform] = {"Easy": [], "Medium": [], "Hard": []}
        difficulty = problem.get("difficulty", "Medium")
        by_platform[platform][difficulty].append(problem)

    for platform, by_difficulty in sorted(by_platform.items()):
        lines.append(f"## {platform}")
        lines.append("")

        for difficulty in ["Easy", "Medium", "Hard"]:
            diff_problems = by_difficulty[difficulty]
            if not diff_problems:
                continue

            lines.append(f"### {difficulty}")
            lines.append("")
            lines.append("| # | Problem | Solution | Notes |")
            lines.append("|---|---------|----------|-------|")

            for p in sorted(diff_problems, key=lambda x: x.get("id", 0)):
                problem_id = p.get("id", "?")
                title = p.get("title", "Unknown")
                link = p.get("link", "#")
                notes = p.get("notes", "")
                solution_path = get_problem_path(p)

                lines.append(f"| {problem_id} | [{title}]({link}) | [Solution](../{solution_path}) | {notes} |")

            lines.append("")

    return "\n".join(lines)


def main():
    print("Generating topic problem lists...")

    # Get all problems from all platforms
    all_problems = get_all_problems()
    print(f"Found {len(all_problems)} problems across all platforms")

    # Group by category
    by_category = group_problems_by_category(all_problems)

    # Get existing topic folders
    topic_folders = get_topic_folders()
    print(f"Found {len(topic_folders)} topic folders: {', '.join(topic_folders)}")

    # Generate problems.md for each topic folder
    for topic in topic_folders:
        topic_dir = TOPICS_DIR / topic
        problems = by_category.get(topic, [])

        content = generate_problems_md(topic, problems)
        problems_md_path = topic_dir / "problems.md"
        problems_md_path.write_text(content)

        print(f"  {topic}: {len(problems)} problems")

    # Report categories that don't have matching topic folders
    unmatched = set(by_category.keys()) - set(topic_folders)
    if unmatched:
        print(f"\nCategories without topic folders: {', '.join(sorted(unmatched))}")
        print("Create folders in topics/ to include these categories.")

    print("\nDone!")


if __name__ == "__main__":
    main()
