public class ZigzagIterator {

    bool firstOne = true;
    int size;
    int index1 = 0;
    int index2 = 0;
    List<int> _v1;
    List<int> _v2;
    public ZigzagIterator(IList<int> v1, IList<int> v2) {
        v1 = v1.ToList();
        v2 = v2.ToList();
        _v1 = v1.ToList();
        _v2 = v2.ToList();
        size = v1.Count() + v2.Count();
    }

    public bool HasNext() {
        if(size > 0)
        {
            size--;
            return true;
        }
        return false;
    }

    public int Next() {
        if(firstOne)
        {
            firstOne = !firstOne;
            if(index1 < _v1.Count())
            {
                Console.WriteLine(index1);
                return _v1[index1++];
            }
            else if(index2 < _v2.Count())
            {
                return _v2[index2++];
            }
            return -1;
        }
        else{
            firstOne = !firstOne;
            if(index2 < _v2.Count())
            {
                
                return _v2[index2++];
            }
            else if(index1 < _v1.Count())
            {
                return _v1[index1++];
            }
            return -1;
            
        }
    }
}

/**
 * Your ZigzagIterator will be called like this:
 * ZigzagIterator i = new ZigzagIterator(v1, v2);
 * while (i.HasNext()) v[f()] = i.Next();
 */
