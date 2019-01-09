public class MovingAverage {
    List<double> queue;
    int _size;
    double sum = 0;
    int n = 0;
    /** Initialize your data structure here. */
    public MovingAverage(int size) {
       queue = new List<double>(); 
        _size = size;
    }
    
    public double Next(int val) {
        if(n == _size)
        { 
            sum -= queue[0];
            queue.Remove(queue[0]);
        }
        else{
            n++;
        }
        queue.Add(val);
        sum += val;
        return sum / queue.Count();
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */
