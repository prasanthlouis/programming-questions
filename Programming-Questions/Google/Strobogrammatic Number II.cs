public class Solution {
    public IList<string> FindStrobogrammatic(int n) {
        var list = Recurse(n,n);
        return list;
    }
    
    public List<string> Recurse(int n, int m)
    {
        if(n == 0)
            return new List<string>(){""};
        if(n == 1)
            return new List<string>(){"0", "1", "8"};
        
        var tempList = Recurse(n - 2, m);
        var lis = new List<string>();
        for(int i = 0 ; i < tempList.Count(); i++)
        {
            if(n != m)
                lis.Add($"0{tempList[i]}0");
            lis.Add($"1{tempList[i]}1");
            lis.Add($"6{tempList[i]}9");
            lis.Add($"8{tempList[i]}8");
            lis.Add($"9{tempList[i]}6");
        }
        
        return lis;
    }
}
