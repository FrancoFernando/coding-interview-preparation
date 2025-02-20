public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        if (!wordList.Contains(endWord)) return 0;

        var wordSet = new HashSet<string>(wordList);
        var queue = new Queue<string>();
        var visited = new HashSet<string>();
        
        queue.Enqueue(beginWord);
        visited.Add(beginWord);
        int length = 1;

        while (queue.Count > 0) {
            int levelSize = queue.Count;
            for (int i = 0; i < levelSize; i++) {
                var currentWord = queue.Dequeue();
                if (currentWord == endWord) return length;
                // look for possible edges
                for (int j = 0; j < currentWord.Length; j++) {
                    char[] chars = currentWord.ToCharArray();
                    for (char c = 'a'; c <= 'z'; c++) {
                        chars[j] = c;
                        string newWord = new string(chars);
                        if (wordSet.Contains(newWord) && !visited.Contains(newWord)) {
                            queue.Enqueue(newWord);
                            visited.Add(newWord);
                        }
                    }
                }
            }
            length++;
        }
        return 0;
    }
}
