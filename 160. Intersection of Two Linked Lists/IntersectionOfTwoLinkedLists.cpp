/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    ListNode *getIntersectionNode(ListNode *headA, ListNode *headB) {
        
        unordered_set<ListNode*> nodeA;
        for (auto it = headA; it != nullptr; it = it->next) {
            nodeA.insert(it);
        }
        
        for (auto it = headB; it != nullptr; it = it->next) {
            if(nodeA.count(it) > 0) return it;
        }
        
        return nullptr;
    }
};