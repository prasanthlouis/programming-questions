public class Solution {
    public IList<int> PancakeSort(int[] A) {
        var largestNumber = A.Count();
        var pancakes = new List<int>();
        while(largestNumber > 0)
        {
            var index = Array.IndexOf(A,largestNumber);
            if(index + 1 == largestNumber)
            {
                largestNumber--;
                continue;
            }
            pancakes.Add(index + 1);
            Reverse(A, index);
            pancakes.Add(largestNumber);
            Reverse(A, largestNumber - 1);
            largestNumber--;  
        }
        return pancakes;
    }
    
    public void Reverse(int[] A, int j)
    {
        int count = j;
        for(int i = 0 ; i <= count / 2 ; i++,j--)
        {
            var temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
    }
}
