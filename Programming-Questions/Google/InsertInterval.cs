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
    public List<Interval> Insert(IList<Interval> intervalp, Interval newInterval) {
        int startInterval = -1;
        int endInterval = -1;
        var answer = new List<Interval>();
        var intervals = intervalp.ToList();
        var found = false;
        
        if(intervals.Count() == 0)
            return new List<Interval>(){newInterval};
        int i = 1;
        for(; i <= intervals.Count(); i++){
            if(newInterval.start <= intervals[i-1].start && !found)
            {
                if(newInterval.end >= intervals[i-1].start)
                {
                      while(i < intervals.Count() && intervals[i].start <= newInterval.end && intervals[i].end <= intervals[i].end)
                          i++;
                    startInterval = Math.Min(newInterval.start, intervals[i-1].start);
                    endInterval = Math.Max(newInterval.end, intervals[i-1].end);
                    answer.Add(new Interval(startInterval, endInterval));
                    
                }
                else if(newInterval.end < intervals[i-1].start)
                {
                    answer.Add(new Interval(intervals[i-1].start, intervals[i-1].end));
                    answer.Add(new Interval(newInterval.start, newInterval.end));
                }
                else{
                    answer.Add(new Interval(newInterval.start, newInterval.end));
                }
                found = true;
            }
            else if(intervals[i-1].start <= newInterval.start && newInterval.start <= intervals[i-1].end)
            {
                startInterval = intervals[i-1].start;
                while(i < intervals.Count() && intervals[i].start <= newInterval.end && intervals[i].end <= intervals[i].end)
                    i++;

                if(newInterval.end < intervals[i-1].start){
                    endInterval = newInterval.end;
                }
                else if(newInterval.end < intervals[i-1].end){
                    endInterval = intervals[i-1].end;
                }
                else{
                    endInterval = newInterval.end;
                }
                answer.Add(new Interval(startInterval, endInterval));
                found = true;
            }else{
                answer.Add(new Interval(intervals[i-1].start, intervals[i-1].end));
            }
        }
        if(!found)
            answer.Add(new Interval(newInterval.start, newInterval.end));

            

        
        return answer.OrderBy(x => x.start).ToList();
    }
}
