public class Solution {
    public IList<int[]> GetSkyline(int[,] buildings) {
        var buildingClass = new Buildings[buildings.GetLength(0) * 2];
        int j = 0;
        for(int i = 0 ; i < buildings.GetLength(0); i++)
        {
            buildingClass[j] = new Buildings();
            buildingClass[j].height = buildings[i,2];
            buildingClass[j].length = buildings[i,0];
            buildingClass[j].isStarting = true;
            
            j++;
            
            buildingClass[j] = new Buildings();
            buildingClass[j].height = buildings[i,2];
            buildingClass[j].length = buildings[i,1];
            buildingClass[j].isStarting = false;
            
            j++;
        }
        var dictionary = new SortedDictionary<int, int>();
        Array.Sort(buildingClass);
        dictionary.Add(0, 1);
        var previousMaximum = 0;
        var answerList = new List<int[]>();
        foreach(var item in buildingClass)
        {
            int currentElementHeight = item.height;
            int length = item.length;
            if(item.isStarting)
            {
                if(dictionary.ContainsKey(currentElementHeight))
                {
                    dictionary[currentElementHeight]++;
                }
                else{
                    dictionary.Add(currentElementHeight, 1);
                }
            }
            else{
                var count = dictionary[currentElementHeight];
                if(count > 0)
                {
                    dictionary[currentElementHeight]--;
                    if(dictionary[currentElementHeight] == 0)
                    {
                        dictionary.Remove(currentElementHeight);
                    }         
                }
                else{
                    dictionary.Remove(currentElementHeight);
                }
            }
            var currentHeight = dictionary.Keys.Last();
            if(currentHeight != previousMaximum)
            {
                answerList.Add(new int[2]{length, currentHeight});
                previousMaximum = currentHeight;
            }
        }
        return answerList;
        
    }
}

public class Buildings : IComparable<Buildings>{
    public int height{get;set;}
    public bool isStarting{get;set;}
    public int length{get;set;}
    
 public int CompareTo(Buildings obj1)
    {
        if(length != obj1.length)
        {
            return length - obj1.length;
        }
        else{
            return (isStarting ? -height :  height )  - (obj1.isStarting? -obj1.height : obj1.height );
        }
    }
}
