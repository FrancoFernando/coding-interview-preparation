/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
    
    int pos = 0;
    
    TreeNode* getSubTree(string const& s) { 
        
        if (s[pos] == '(') {
            pos++;
            return str2tree(s);
        }
        
        return nullptr;
    }
    
    int getValue(string const& s) {
        
        int sign = 1;
        
        if (s[pos] == '-') {
            pos++;
            sign = -1;
        }
        
        int val = s[pos++] - '0';
        
        while (isdigit(s[pos])) val = (val*10) + s[pos++] - '0';
        
        return val * sign;
    }
    
public:
    TreeNode* str2tree(string s) {
        
        if (pos >= s.size()) return nullptr;
            
        //build current node
        TreeNode* node = new TreeNode(getValue(s));                    
        node->left = getSubTree(s);    
        node->right = getSubTree(s); 
        
        //skip the closing parenthesis
        pos++;  
        
        return node;
    }
};

