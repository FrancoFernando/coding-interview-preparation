class Solution {
    
    class Trie {
        
        struct TrieNode {
            TrieNode* children[26] = {nullptr};
            TrieNode(){};
        };
        
        TrieNode* root;
        int minLength = 0;
        
        void minimumLength(TrieNode* node, int depth) {
       
            bool isLeaf = true;
            for (auto const& child : node->children) {
                if (child) {
                    isLeaf = false;
                    minimumLength(child, depth+1);
                }
            }
            if (isLeaf) minLength += (depth+1);
        }
        
        public:
        
        Trie(){root = new TrieNode();}
        
        void insert(string const& s) {
               
            TrieNode* it = root;
            for (auto rit = s.crbegin(); rit != s.crend(); ++rit) {           
                char c = *rit;
                if (!it->children[c-'a']) {
                    it->children[c-'a'] = new TrieNode();
                }
                it = it->children[c-'a'];
            }
        }
        
        int getMinLength() {
            minLength = 0;
            minimumLength(root,0);
            return minLength;
        }        
    };
       
public:
    int minimumLengthEncoding(vector<string>& words) {
        
        int minLength = 0;
        Trie t;
        for (string const& word: words) {
            t.insert(word);
        }
        return t.getMinLength();
    }
};