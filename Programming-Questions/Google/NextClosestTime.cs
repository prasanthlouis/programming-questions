public class Solution {
    public string NextClosestTime(string time) {
        var result = new StringBuilder();
        var sortedTi = new StringBuilder();
        var sortedTime = string.Concat(time.OrderBy(x => x));
        sortedTi.Append(sortedTime);
        sortedTi.Length = sortedTi.Length - 1;
        sortedTime = sortedTi.ToString();       
        result.Append(time);
        result[4] = FindNumber(time[4], sortedTime, '9');
        if(result[4] > time[4])
            return result.ToString();
        result[3] = FindNumber(time[3], sortedTime, '5');
        if(result[3] > time[3])
            return result.ToString();
        result[1] = FindNumber(time[1], sortedTime, result[0] == '2' ? '3' : '9');
        if(result[1] > time[1])
            return result.ToString();
        result[0] = FindNumber(time[0], sortedTime, '2');
        return result.ToString();
        
        
    }
    
    public char FindNumber(char currentTime, string sortedTime, char upperLimit)
    {
        var index = sortedTime.IndexOf(currentTime);
        if(++index >= sortedTime.Length)
            return sortedTime[0];
        var result = sortedTime[index];
        while(upperLimit < result || currentTime == result)
        {
            index++;
            if(index >= sortedTime.Length)
            {
                return sortedTime[0];
            }
            result = sortedTime[index];
        }
        return result;
    }
}
