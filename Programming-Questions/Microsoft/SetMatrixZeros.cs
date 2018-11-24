public class Solution {
    public void SetZeroes(int[,] matrix) {
        var list = new List<(int,int)>();
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if(matrix[i,j] == 0)
                {
                    var named = (Key: i, Value: j);
                    list.Add(named);
                    Console.WriteLine($"{i},{j}");
                }
            }
        }
        for(int i = 0; i < list.Count; i++)
        {
            var tuple = list[i];
            var index = tuple.Item1;
            var index2 = tuple.Item2;
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[index,j] = 0;
            }
            for(int k = 0 ; k < matrix.GetLength(0); k++)
            {
                matrix[k,index2] = 0;
            }
        }
        
    }
}
