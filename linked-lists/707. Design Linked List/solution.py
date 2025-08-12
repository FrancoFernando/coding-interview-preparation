class MyLinkedList:

    class Node:   
        def __init__(self, val : int, next = None):
            self.next = next
            self.val = val

    def __init__(self):
        self.head = None
        self.tail = None
        self.length = 0

    def getNode(self, index: int):
        if index < 0 or index >= self.length:
            return None

        curr = self.head
        for _ in range(index):
            curr = curr.next
        return curr

    def get(self, index: int) -> int:
        node = self.getNode(index)
        return node.val if node else -1

    def addAtHead(self, val: int) -> None:
        new_node = self.Node(val, self.head)
        self.head = new_node
        if not self.tail:
            self.tail = new_node
        self.length += 1
        

    def addAtTail(self, val: int) -> None:
        new_node = self.Node(val)
        if self.tail:
            self.tail.next = new_node
        else: 
            self.head = new_node
        self.tail = new_node
        self.length += 1


    def addAtIndex(self, index: int, val: int) -> None:

        if index < 0 or index > self.length:
            return

        prev = self.getNode(index-1)
        if not prev:
            self.addAtHead(val)
        elif not prev.next:
            self.addAtTail(val)
        else:
            prev.next = self.Node(val, prev.next)
            self.length += 1

    def deleteAtHead(self):
        if self.head:
            self.head = self.head.next
            self.length -= 1
            
    def deleteAtIndex(self, index: int) -> None:

        if index < 0 or index >= self.length:
            return

        prev = self.getNode(index-1)
        if not prev:
            self.deleteAtHead()
        elif not prev.next.next:
            prev.next = None
            self.tail = prev
            self.length -= 1
        else:
            prev.next = prev.next.next
            self.length -= 1

# Your MyLinkedList object will be instantiated and called as such:
# obj = MyLinkedList()
# param_1 = obj.get(index)
# obj.addAtHead(val)
# obj.addAtTail(val)
# obj.addAtIndex(index,val)
# obj.deleteAtIndex(index)
