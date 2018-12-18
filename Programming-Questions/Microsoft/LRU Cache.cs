//Faster LRU Cache

public class LRUCache {
    Dictionary<int,LinkedListNode<CacheObject>> dictionary;
    LinkedList<CacheObject> linkedList;
    int capacity;
    int count = 0;
    public LRUCache(int capacity) {
        this.capacity = capacity;
        dictionary = new Dictionary<int, LinkedListNode<CacheObject>>();
        linkedList = new LinkedList<CacheObject>();
    }
    
    public int Get(int key) {
        if(!dictionary.ContainsKey(key))
            return -1;
        
        var cacheObject = dictionary[key];
        if(cacheObject != linkedList.First)
        {
            linkedList.Remove(cacheObject);
            linkedList.AddFirst(cacheObject);
        }
        
        return cacheObject.Value.Val;
    }
    
    public void Put(int key, int value) {
        var cacheObject = new CacheObject(){
                Val = value,
                Key = key
            };
        if(!dictionary.ContainsKey(key))
        {
            dictionary[key] = linkedList.AddFirst(cacheObject);
            Console.WriteLine(dictionary[key].Value.Val);
            if(count == capacity)
            {
                var last = linkedList.Last;
            linkedList.RemoveLast();
            dictionary.Remove(last.Value.Key);
            }
            else{
                count++;
            }
        }
        else{
            var item = dictionary[key];
            item.Value.Val = value;
            if(item != linkedList.First)
            {
                linkedList.Remove(item);
                linkedList.AddFirst(item);
            }
        }
        
    }
}



public class CacheObject{
    public int Val{get;set;}
    public int Key{get;set;}
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */

//Time limit exceeded
public class LRUCache {
    Dictionary<int,CacheObject> dictionary;
    int capacity;
    public LRUCache(int capacity) {
        this.capacity = capacity;
        dictionary = new Dictionary<int, CacheObject>(capacity);
    }
    
    public int Get(int key) {
        if(!dictionary.ContainsKey(key))
            return -1;
        else{
            var item = dictionary[key];
            item.Count = 0;
            dictionary[key] = item;
            
        }
        foreach(var x in dictionary)
        {
            x.Value.Count++;
        }
        return dictionary[key].Val;
    }
    
    public void Put(int key, int value) {
        var cacheObject = new CacheObject(){
            Val = value,
            Count = 0
        };
        if(dictionary.ContainsKey(key)) {
            dictionary[key] = cacheObject;
            Iterate();
            return;
            }
        if(dictionary.Count() == capacity)
        {
            var max = int.MinValue;
            var selectedKey = 0;
            foreach(var item in dictionary)
            {
                if(item.Value.Count > max)
                {
                    selectedKey = item.Key;
                    max = item.Value.Count;
                }
            }
            dictionary.Remove(selectedKey);
            
        }

         
            dictionary.Add(key, cacheObject);
            
        Iterate();
        
    }
    
public void Iterate(){
    foreach(var x in dictionary)
        {
            x.Value.Count++;
        }
}
}



public class CacheObject{
    public int Val{get;set;}
    public int Count{get;set;}
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
