/*
// Definition for a Node.
class Node {
public:
    int val;
    Node* next;
    Node* random;
    
    Node(int _val) {
        val = _val;
        next = NULL;
        random = NULL;
    }
};
*/

class Solution {
    
    //map each node in the input list to its clone in the copy list
    unordered_map<Node*, Node*> node2clone;

public:
    Node* copyRandomList(Node* head) {
        
        if (!head) return nullptr;
        
        //clone the current node
        auto clone = new Node(head->val);
        node2clone[head] = clone; //important: fill before recursive call
        clone->next = copyRandomList(head->next);
        
        //link the random pointer
        if (!head->random) clone->random = nullptr;
        else clone->random = node2clone[head->random];
        return clone;        
    }
};