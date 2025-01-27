public class Solution {

    public class Trie {
        private class Node {
            public Node[] Children { get; } = new Node[26];
            public SortedSet<string> Words { get; } = new SortedSet<string>();

            public Node() {
                Children = new Node[26];
                Words = new SortedSet<string>();
            }
        }

        private Node _root;

        public Trie() {
            _root = new Node();
        }

        public void Insert (string word) {
            var current = _root;
            foreach (char c  in word) {
                int index = c-'a'; 
                current.Children[index] ??= new Node();
                current = current.Children[index];
                current.Words.Add(word);
                if (current.Words.Count > 3) {
                    current.Words.Remove(current.Words.Last());
                }
            }
        }

        public List<string> Search (string prefix) {
            var current = _root;
            foreach (char c in prefix) {
                int index = c-'a'; 
                current = current.Children[index];
                if (current == null)
                    return new List<string>();
            }
            return current.Words.ToList();
        }
    }

    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        
        var result = new List<IList<string>>();
        var trie = new Trie();

        foreach(var product in products) {
            trie.Insert(product);
        }

        var prefix = new StringBuilder();

        foreach(char c in searchWord) {
            prefix.Append(c);
            result.Add(trie.Search(prefix.ToString()));
        }
        return result;
    }
}
