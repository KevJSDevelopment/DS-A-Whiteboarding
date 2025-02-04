/*
Given a stream of integers and a window size, calculate the moving average of all integers in the sliding window.

Implement the MovingAverage class:

MovingAverage(int size) Initializes the object with the size of the window size.
double next(int val) Returns the moving average of the last size values of the stream.
 

Example 1:

Input
["MovingAverage", "next", "next", "next", "next"]
[[3], [1], [10], [3], [5]]
Output
[null, 1.0, 5.5, 4.66667, 6.0]

Explanation
MovingAverage movingAverage = new MovingAverage(3);
movingAverage.next(1); // return 1.0 = 1 / 1
movingAverage.next(10); // return 5.5 = (1 + 10) / 2
movingAverage.next(3); // return 4.66667 = (1 + 10 + 3) / 3
movingAverage.next(5); // return 6.0 = (10 + 3 + 5) / 3

*/

public class MovingAverage {
    private List<int> queue;
    private double avg = 0.0;
    private readonly int length ;
    public MovingAverage(int size) {
        queue = new();
        length = size;
    }
    
    public double Next(int val) { 
        int sum = 0;
        queue.Add(val);
        if(queue.Count() > length) queue.RemoveAt(0);

        int i = 0;
        while(i < queue.Count())
        {
            sum += queue[i];
            i++;
        }
        
        avg = i < length ? sum / (double)i : sum / (double)length;
        return avg;
    }
}