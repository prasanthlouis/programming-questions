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
