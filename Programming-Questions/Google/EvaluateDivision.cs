public class Solution {
    
    public double Dfs(int s, int t, double[,] graph, double result, HashSet<int> hashSet)
    {
        if(s == t)
            return 1;
        if(hashSet.Contains(s))
            return 0;
        hashSet.Add(s);
        for(int i = 0; i < graph.GetLength(0); i++)
        {
            if(graph[s,i] > 0 && !hashSet.Contains(i))
            {
                if(i == t)
                    return result * graph[s,i];
                var count = Dfs(i, t, graph, result * graph[s,i], hashSet);
                if(count > 0)
                    return count;
            }
        }
        return 0;
    }
    public double[] CalcEquation(string[,] equations, double[] values, string[,] queries) {
        var dictionary = new Dictionary<string,int>();
        int z = 0;
        var result = new double[queries.GetLength(0)];
        foreach(var x in equations)
        {
            if(!dictionary.ContainsKey(x))
            {
                dictionary.Add(x,z++);
            }
        }
        var graph = new double[z,z];
        for(int i = 0 ; i < values.Count(); i++)
        {
            graph[dictionary[equations[i,0]], dictionary[equations[i,1]]] = values[i];
            graph[dictionary[equations[i,1]], dictionary[equations[i,0]]] = 1 / values[i];
        }
        
        for(int j = 0 ; j < graph.GetLength(0) ; j++)
        {
            graph[j,j] = 1;
        }
        
        for(int i = 0 ; i < queries.GetLength(0); i++)
        {
            var s = queries[i,0];
            var t = queries[i,1];
            if(!dictionary.ContainsKey(s) || !dictionary.ContainsKey(t))
            {
                result[i] = -1.0;
            }
            else{
                var tempResult = Dfs(dictionary[s],dictionary[t],graph,1, new HashSet<int>());
                result[i] = tempResult > 0 ? tempResult : -1.0;
            }
        }
        return result;
        
    }
}
