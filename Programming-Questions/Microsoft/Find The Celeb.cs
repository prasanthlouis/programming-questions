/* The Knows API is defined in the parent class Relation.
      bool Knows(int a, int b); */

public class Solution : Relation {
    public int FindCelebrity(int n) {
        var candidate = 0;
        for(int i = 1 ; i < n ; i++)
        {
            if(Knows(candidate, i))
                candidate = i;
        }
        
        for(int i = 0 ; i < n ; i++)
        {
            if(candidate != i && Knows(candidate, i))
                return -1;
        }
        
        for(int i = 0 ; i < n ; i++)
        {
            if(candidate != i && !Knows(i, candidate))
                return -1;
        }
        return candidate;
    }
}
