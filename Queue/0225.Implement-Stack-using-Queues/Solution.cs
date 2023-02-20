public class MyStack {

    Queue<int> PushQueue;
    Queue<int> PopQueue;
    int top;

    public MyStack() {
        PushQueue = new Queue<int>();
        PopQueue = new Queue<int>();
    }
    
    public void Push(int x) {
        PushQueue.Enqueue(x);
        top = x;
    }
    
    public int Pop() {
        if (PopQueue.Count == 0) MoveFromPushToPop();
        return PopQueue.Dequeue();
    }
    
    public int Top() {
        return top;
    }
    
    public bool Empty() {
        return PushQueue.Count == 0;
    }

    private void MoveFromPushToPop() {
        while (PushQueue.Count > 1) {
            top = PushQueue.Dequeue();
            PopQueue.Enqueue(top);
        }
        (PushQueue, PopQueue) = (PopQueue, PushQueue);
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
