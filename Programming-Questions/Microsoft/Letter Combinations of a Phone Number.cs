public class Solution {
    List<string> answerList = new List<string>();
    List<string> inputList = new List<string>(){
        "",
        "",
        "abc",
        "def",
        "ghi",
        "jkl",
        "mno",
        "pqrs",
        "tuv",
        "wxyz"
    };
    public IList<string> LetterCombinations(string digits) {
        if(string.IsNullOrWhiteSpace(digits))
            return new List<string>();
        var stringBuilder = new StringBuilder();
        char[] result = new char[digits.Length]; 
        Recurse(digits, stringBuilder, 0); 
        return answerList;
    }
    
    public void Recurse(string digits, StringBuilder stringBuilder, int nextNumberIndex)
    {
        Console.WriteLine($"{digits} {stringBuilder.ToString()} {nextNumberIndex}");
        if(nextNumberIndex == digits.Length)
        { 
            answerList.Add(stringBuilder.ToString());
            return;
        }
        var _ = int.TryParse(digits[nextNumberIndex].ToString(), out var index);
        
        for(int i = 0 ; i < inputList[index].ToString().Length ; i++)
        {
            if(!(nextNumberIndex >= stringBuilder.Length))
            {
            stringBuilder[nextNumberIndex] =inputList[index].ToString()[i];
            }
            else
            {
                stringBuilder.Append(inputList[index].ToString()[i]);
            }
            Recurse(digits, stringBuilder, nextNumberIndex + 1);   
            if (digits[nextNumberIndex] == 0 || digits[nextNumberIndex] == 1) 
            return; 
        }
    }
}
