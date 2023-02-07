public class MovingAverage {

    private int _size;
    private Queue<int> _window;
    private double _windowSum = 0d;

    public MovingAverage(int size) {
        _window = new Queue<int>(size);
        _size = size;
    }
    
    public double Next(int val) {
        
        if (_window.Count == _size) {
            _windowSum -= _window.Dequeue();
        }
        _windowSum += val;
        _window.Enqueue(val);
        return _windowSum / _window.Count;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */
