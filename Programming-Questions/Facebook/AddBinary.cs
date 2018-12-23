
public class Solution {
    int carry = 0;
    public string AddBinary(string a, string b) {
        var startingA = a.Length - 1;
        var startingB = b.Length - 1;
        var stringBuilder = new StringBuilder();
        int carry = 0;
        int sum = 0;
        while(startingA >= 0 || startingB >= 0)
        {
            sum = carry;
            if(startingA >= 0)
            {
                sum += a[startingA--] - '0';
            }
            if(startingB >= 0)
            {
                sum += b[startingB--] - '0';
            }
            stringBuilder.Insert(0, sum % 2);
            carry = sum / 2;
        }
        if(carry != 0)
        {
            stringBuilder.Insert(0, carry);
        }
        return stringBuilder.ToString();
    }
    

}



public class Solution {
    int carry = 0;
    public string AddBinary(string a, string b) {
        var startingA = a.Length - 1;
        var startingB = b.Length - 1;
        var longerString = 0;
        var answer = string.Empty;
        var difference = Math.Min(a.Length, b.Length);   
        for(int i = 0 ; i < difference ; i++)
        {      
            var characterA = a[startingA--];
            var characterB = b[startingB--];
            var output = Helper(characterA, characterB);
            answer += output;
        }
        var diff = startingA - startingB;
        if(diff > 0)
        {
            diff--;
            while(diff >= 0)
            {
                answer += Helper(a[diff--] , '0');
            }
        }
        else if(diff < 0){
            diff = startingB - startingA;
            diff--;
            while(diff >= 0)
            {
                answer += Helper(b[diff--], '0');
            }
            
        }
        if(carry == 1)
        {
            answer += "1";
        }
        return new string(answer.Reverse().ToArray());
    }
    
    public int Helper(char characterA, char characterB)
    {
        var a = int.Parse(characterA.ToString());
        var b = int.Parse(characterB.ToString());
        var output = a + b + carry;
        switch(output){
            case 3:
            carry = 1;
            return 1;
            case 2: 
            carry = 1;
            return 0;
            case 1:
                carry = 0;
                return 1;
            case 0:
                carry = 0;
                return 0;
            default:
                return -1;
        }
        return -1;
    }
}
