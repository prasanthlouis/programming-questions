public class Solution {
    public bool CanFinish(int numCourses, int[,] prerequisites) {
        var arrayList = new List<int>[numCourses];
        var visited = new bool[numCourses];
        for(int i = 0; i < numCourses; i++)
        {
            arrayList[i] = new List<int>();
        }
        
        for(int i = 0; i < prerequisites.GetLength(0); i++)
        {
            arrayList[prerequisites[i,1]].Add(prerequisites[i,0]);
        }
        
        for(int i =0 ; i < numCourses; i++)
        {
            if(!Dfs(arrayList, visited, i))
                return false;
        }
        return true;
    }
    
    public bool Dfs(List<int>[] arrayList, bool[] visited, int course)
    {
        if(visited[course])
            return false;
        visited[course] = true;
        
        for(int i = 0 ; i < arrayList[course].Count(); i++)
        {
            if(!Dfs(arrayList, visited, arrayList[course][i]))
                return false;
        }
        visited[course] = false;
        return true;
    }
}
