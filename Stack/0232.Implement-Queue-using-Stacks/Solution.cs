public class MyQueue {

    Stack<int> Enqueue, Dequeue;

    public MyQueue() {
        Enqueue = new Stack<int>();
        Dequeue = new Stack<int>();
    }
    
    public void Push(int x) {
        Enqueue.Push(x);
    }
    
    public int Pop() {
        if (Dequeue.Count == 0) MoveEnqueueToDequeue();
        return Dequeue.Pop();
    }
    
    public int Peek() {
        if (Dequeue.Count == 0) MoveEnqueueToDequeue();
        return Dequeue.Peek();
    }

    private void MoveEnqueueToDequeue() {
        while (Enqueue.Count > 0) Dequeue.Push(Enqueue.Pop());
    }
    
    public bool Empty() {
        return Dequeue.Count == 0 && Enqueue.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
