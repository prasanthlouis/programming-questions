public class Solution {
     List<string> LESS_THAN_20 = new List<string>(){"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
List<string> TENS = new List<string>(){"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
List<string> THOUSANDS = new List<string>(){"", "Thousand", "Million", "Billion"};
    public string NumberToWords(int num) {
        if(num == 0)
            return "Zero";
        
        int i = 0;
        string word = string.Empty;
        while(num > 0)
        {
            if(num % 1000 != 0)
            {
              word = Word(num % 1000) + THOUSANDS[i] +" " + word;
            }
            num = num / 1000;
            i++;
        }
        
        return word.Trim();
    }
    
    public string Word(int number)
    {
        if (number == 0)
        return "";
        if(number < 20)
        {
            return LESS_THAN_20[number] + " ";
        }
        if(number < 100)
        {
            var tens = number/10;
            return TENS[tens] +" "+ Word(number % 10) ;
        }
        else
        {
            var hundred = number / 100;
            return LESS_THAN_20[hundred] + " Hundred " + Word(number % 100);      
        } 
        return string.Empty;
    }
}
