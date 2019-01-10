public class Solution {
    public int[] NextGreaterElement(int[] findNums, int[] nums) {
        var answer = new int[findNums.Count()];
        var numsList = nums.ToList();
        var stack = new Stack<int>();
        var dictionary = new Dictionary<int,int>();
        for(int i = 0 ; i < nums.Count(); i++)
        {
            while(stack.Count() > 0 && stack.Peek() < nums[i])
                dictionary.Add(stack.Pop(), nums[i]);
            stack.Push(nums[i]);        
        }
        for(int i = 0; i < findNums.Count(); i++)
        {
            if(dictionary.ContainsKey(findNums[i]))
                findNums[i] = dictionary[findNums[i]];
            else{
                findNums[i] = -1;
            }
        }
        return findNums;
    }
}

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
