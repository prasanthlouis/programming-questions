//Time Complexity = O(n)
//Space complexity = O(n)

//BIt shorter
public class Solution {
    public int[] PlusOne(int[] digits) {
        for(int i = digits.Count() - 1 ; i >= 0 ; i--)
        {
            if(digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        var newInteger = new int[digits.Count() + 1];
        for(int i = digits.Count() - 1 ; i >= 0 ; i--)
        {
            newInteger[i]  = digits[i];
        }
        newInteger[0] = 1;
        return newInteger;
    }
}

//My own
public class Solution {
    public int[] PlusOne(int[] digits) {
        int length = digits.Count() - 1;
        int carry = 0;
        bool firstTime = true;
        int additional = 1;
        do{
            if(length < 0)
                break;
            if(!firstTime)
            {
                additional = 0;
            }
            var temp = (digits[length] + additional + carry) % 10;
            carry = (digits[length] + additional + carry) / 10;
            digits[length] = temp;
            length--;
            firstTime = false;
        } while(carry != 0);
          var carryAnswer = new int[digits.Count() + 1];
        
        if(carry != 0)
        {
            for(int i = digits.Count() - 1 ; i > 0; i--)
            {
                carryAnswer[i] = digits[i];
            }
            carryAnswer[0] = carry;    
        }
        return carry != 0 ? carryAnswer : digits;
    }
}
