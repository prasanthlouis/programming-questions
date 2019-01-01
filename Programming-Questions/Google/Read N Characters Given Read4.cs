/* The Read4 API is defined in the parent class Reader4.
      int Read4(char[] buf); */

public class Solution : Reader4 {
    /**
     * @param buf Destination buffer
     * @param n   Maximum number of characters to read
     * @return    The number of characters read
     */
    public int Read(char[] buf, int n) {
        var tempbuf = new char[4];
        int count = 0;
        bool firstTime = true;
        int charactersRead = 4;
        while(charactersRead == 4)
        {
            charactersRead = Read4(tempbuf);
            var actualCount = Math.Min(charactersRead,  n- count);
            for(int i = 0 ; i < actualCount; i++)
            {
                buf[count] = tempbuf[i];
                count++;
            }
        }
        return count;
    }
}
