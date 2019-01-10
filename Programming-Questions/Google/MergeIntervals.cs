/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public IList<Interval> Merge(IList<Interval> intervals) 
    {
        IList<Interval> mergedIntervals = new List<Interval>();
        if (null == intervals || intervals.Count == 0) return mergedIntervals;
        if (intervals.Count == 1) return intervals;
        
        intervals = intervals.OrderBy(x => x.start).ToList();
        
        var start = intervals[0].start;
        var end = intervals[0].end;
        for(int i = 1 ; i < intervals.Count; i++)
        {
            if(end < intervals[i].start)
            {
                mergedIntervals.Add(new Interval(start, end));
                start = intervals[i].start;
                end = intervals[i].end;
            }
            else{
                end = Math.Max(end, intervals[i].end);
            }
        }
        mergedIntervals.Add(new Interval(start,end));
        return mergedIntervals;
    }
  
}
