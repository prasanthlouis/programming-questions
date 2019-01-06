public class Solution {
    public IList<int> PowerfulIntegers(int x, int y, int bound) {
        if(x == 1)
        {
            if(y == 1)
            {
                if(bound == 1 || bound == 0)
                    return new List<int>();
                            else{
                return new List<int>(){2};
            }
            }
        }
        
        var list = new List<int>();
        int i = 0;
        int j = 0;
        var previous = int.MinValue;
        var current = int.MaxValue;
        while((x > y ? Math.Pow(x,i) <= bound : Math.Pow(y,j) <= bound))
        {
                
                if(Math.Pow(x,i) + Math.Pow(y,j) <= bound && previous != current)
                {
                    previous = (int) (Math.Pow(x,i) + Math.Pow(y,j));
                    Console.WriteLine(previous);
                    list.Add((int)(Math.Pow(x,i) + Math.Pow(y,j)));
                    if(x>y)
                    {j++;
                     }
                    else{
                      i++;     
                    } 
                    current = (int) (Math.Pow(x,i) + Math.Pow(y,j));
                }
            else{
                previous = int.MinValue;
                current = int.MaxValue;
                if(x > y)
                {
                    i++;
                    j=0;
                }
                else{
                    j++;
                    i = 0;
                }
            }
        }
        return list.Distinct().ToList();
    }
}
