public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        var noOfRows = matrix.GetLength(0);
        var noOfColumns = matrix.GetLength(1);
        if (matrix == null || matrix.GetLength(0) == 0) {
            return false;
        }

        var diagonal = Math.Min(noOfRows, noOfColumns);
        noOfRows--;
        noOfColumns--;
        for(int i = 0; i < diagonal ; i++)
        {
            var vertical = Recurse(matrix, target, i, noOfColumns, true);
            var horizontal = Recurse(matrix, target, i, noOfRows, false);
            if(vertical || horizontal)
                return true;
        }
        return false;
    }
    
    public bool Recurse(int[,] matrix, int target, int i, int cols, bool vertical)
    {
        int low = i;
        int high = cols;
        
        int start = low;
        while(low <= high)
        {
            var mid = (low + high) / 2;
            if(vertical)
            {
                if(target > matrix[start, mid])
                {
                    
                    low = mid + 1;
                }
                else if(target < matrix[start,mid])
                {
                    high = mid - 1;
                }
                else{
                    return true;
                }
            }
            else{
                if(target > matrix[mid, start])
                {
                    low = mid + 1;
                }
                else if(target < matrix[mid,start])
                {
                    high = mid - 1;
                }
                else
                {
                    return true;
                }
                
            }
            
        }
            return false;
        
    }
}
