#!/usr/bin/env python3
"""
Generate global statistics across all platforms
"""

import json
from pathlib import Path
from datetime import datetime

def load_platform_metadata(platform):
    """Load metadata from a specific platform"""
    metadata_path = Path(platform) / "metadata.json"
    if metadata_path.exists():
        with open(metadata_path, 'r') as f:
            return json.load(f)
    return {"problems": []}

def generate_global_stats():
    """Generate statistics across all platforms"""
    platforms = {
        "LeetCode": "leetcode",
    }
    
    total_stats = {
        "total": 0,
        "easy": 0,
        "medium": 0,
        "hard": 0
    }
    
    platform_breakdown = {}
    
    # Collect stats from each platform
    for platform_name, platform_dir in platforms.items():
        data = load_platform_metadata(platform_dir)
        problems = data.get("problems", [])
        
        easy = len([p for p in problems if p.get('difficulty') == 'Easy'])
        medium = len([p for p in problems if p.get('difficulty') == 'Medium'])
        hard = len([p for p in problems if p.get('difficulty') == 'Hard'])
        total = len(problems)
        
        platform_breakdown[platform_name] = {
            "easy": easy,
            "medium": medium,
            "hard": hard,
            "total": total
        }
        
        total_stats["total"] += total
        total_stats["easy"] += easy
        total_stats["medium"] += medium
        total_stats["hard"] += hard
    
    # Update main README
    update_main_readme(total_stats, platform_breakdown)
    
    print("✅ Global stats generated")
    print(f"📊 Total problems: {total_stats['total']}")

def update_main_readme(total_stats, platform_breakdown):
    """Update the main README with current stats"""
    # Implementation here...
    pass

if __name__ == "__main__":
    generate_global_stats()
