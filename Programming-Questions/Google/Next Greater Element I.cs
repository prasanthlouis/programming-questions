public class Solution {
    public int[] NextGreaterElement(int[] findNums, int[] nums) {
        var answer = new int[findNums.Count()];
        var numsList = nums.ToList();
        for(int i = 0 ; i < findNums.Count(); i++)
        {
            var element = findNums[i];
            var index = numsList.IndexOf(element);
            if(index + 1 == numsList.Count())
                answer[i] = -1;
            else{
                while(index < numsList.Count() && element >= numsList[index])
                    index++;
                    if(index == numsList.Count())
                        answer[i] = -1;
                else
                answer[i] = numsList[index];
            }
            
        }
        return answer;
    }
}
