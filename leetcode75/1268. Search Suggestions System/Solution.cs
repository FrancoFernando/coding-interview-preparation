public class Solution {

    public class Trie {
        private class Node {
            Node[] Children;
            bool IsEndWord;

            public Node() {
                Children = new Node[26];
                IsEndWord = false;
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
                current[index] ??= new Node();
                current = current[index];
            }
            current.IsEndWord = true;
        }

        public List<string> Search (string prefix) {
            var result = new List<string>();
        }

        private void Dfs(string word, int index, Node node, List<string> result) {

            if (node.IsEndWord) {
                result.Add(word);
                return;
            }

            int trieIndex = word[index]-'a';
            if (node.Children[trieIndex]) {
                
            }
        }
    }



    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        
        var result = new List<IList<string>>();
        var trie = new Trie();
        string prefix = "";

        foreach(var product in products) {
            trie.Insert(product);
        }

        foreach(char c in searchWord) {
            var suggestions = new List<string>();
            prefix = prefix + c;
            suggestions.Add(trie.Search(prefix));
        }
        return result;
    }
}
