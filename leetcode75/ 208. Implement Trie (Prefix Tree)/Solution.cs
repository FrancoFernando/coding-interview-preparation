public class Trie {

    private const int AlphabetSize = 26;
    private readonly Node _root;

    private class Node {
        public Node[] Children { get; }
        public bool IsEndOfWord { get; set; }

        public Node() {
            Children = new Node[AlphabetSize];
            IsEndOfWord = false;
        }
    }

    public Trie() {
        _root = new Node();
    }
    
    public void Insert(string word) {
        Node current = _root;
        foreach (char c in word) {
            int index = c - 'a';
            current.Children[index] ??= new Node();
            current = current.Children[index];
        }
        current.IsEndOfWord = true;
    }
    
    public bool Search(string word) {
        Node node = FindNode(word);
        return node != null && node.IsEndOfWord;
    }
    
    public bool StartsWith(string prefix) {
        return FindNode(prefix) != null;
    }

    private Node FindNode(string s) {
        Node current = _root;
        foreach (char c in s) {
            int index = c - 'a';
            if (current.Children[index] == null) {
                return null;
            }
            current = current.Children[index];
        }
        return current;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
