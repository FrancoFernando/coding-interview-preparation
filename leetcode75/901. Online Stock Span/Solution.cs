public class StockSpanner {
    private Stack<(int Price, int Day)> _stack;
    private int _day;

    public StockSpanner() {
        _stack = new Stack<(int, int)>();
        _day = 0;
    }
    
    public int Next(int price) {
        _day++;

        while (_stack.Count > 0 && _stack.Peek().Price <= price) {
            _stack.Pop();
        }

        int span = _stack.Count > 0 ? _day - _stack.Peek().Day : _day;
        _stack.Push((Price: price, Day: _day));

        return span;
    }
}
