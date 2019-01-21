public class Solution {
    public int TotalFruit(int[] tree) {
        var start = 0;
        var end = 0;
        var counter = 0;
        var dict = new Dictionary<int,int>();
        var length = 0;
        var head = 0;
        var max = 0;
        while(end < tree.Count())
        {
            if(!dict.ContainsKey(tree[end]))
            {
                dict.Add(tree[end], 1);
                counter++;
            }
            else{
                dict[tree[end]]++;
            }
            
            length++;
            
            
            if(counter <= 2 && length > max)
            {
                max = length;
            }
            
            while(counter > 2)
            {

                         dict[tree[start]]--;
                        
                         if(dict[tree[start]] == 0)
                         {
                            dict.Remove(tree[start]);
                            counter--;
                         }
                        start++;
                        length--;

            }
            end++;

        }
        return max;
    }
}

public class Solution {
    public int TotalFruit(int[] tree) {
        var max = 0;
        var fastPointer = 0;
        var slowPointer = 0;
        var count = 0;
        var list = new List<int>();
        var distincts = 0;
        while(fastPointer < tree.Count())
        {
            var element = tree[fastPointer];
            if(!list.Contains(element))
            {
                list.Add(element);
                distincts++;
            }
            if(distincts > 2)
            {
                list.Clear();
                distincts = 0;
                fastPointer--;
                                var prevElement = tree[fastPointer];

                while(tree[fastPointer] == prevElement)
                        fastPointer--;


                if(count > max)
                    max = count;
                count = 0;
            }else{
                         count++;
   
            }
            fastPointer++;
        }
        if(count > max)
            max = count;
        return max;
    }
}
