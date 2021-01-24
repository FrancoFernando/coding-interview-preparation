class Solution {
public:
    ListNode* mergeKLists(vector<ListNode*>& lists) {
        
        auto cmp = [](auto const& lhs, auto const& rhs) {
            return lhs->val > rhs->val;
        };
        
        priority_queue<ListNode*, vector<ListNode*>, decltype(cmp)> pq(cmp);
        for (auto& list : lists) if (list) pq.push(list);
        
        ListNode *head = nullptr;
        ListNode **it = &head;
        
        while(!pq.empty()) {         
            *it = pq.top();
            if (pq.top()->next) pq.push(pq.top()->next);
            pq.pop();
            it = &(*it)->next;
        }
        
        return head;
    }
};