public class Solution {
    public bool ValidUtf8(int[] data) {
        var nextByte = 2;
        var oneByte = 0;
        var twoBytes = 6;
        var threeBytes = 14;
        var fourBytes = 30;
        var firstTimeCheck = true;
        var expectedBytes = 0;
        for(int i = 0 ; i < data.Count(); i++)
        {
            if(firstTimeCheck)
            {
                if((data[i] >> 7) == oneByte)
                    continue;
                if((data[i] >> 5) == twoBytes)
                    expectedBytes = 1;
                else if((data[i] >> 4) == threeBytes)
                    expectedBytes = 2;
                else if((data[i] >> 3) == fourBytes)
                    expectedBytes = 3;
                else
                    return false;
                
             firstTimeCheck = false;
            }
            else if((data[i] >> 6) == nextByte){
                    expectedBytes--;
                if(expectedBytes == 0){
                    firstTimeCheck = true;
                }
            }
            else{
                    return false;
                }
        }
        
        return expectedBytes == 0;
    }
}
