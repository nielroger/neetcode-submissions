public class LRUCache {

    Dictionary<int, int> map = new Dictionary<int, int>();
    int capacity;
    LinkedList<int> deque = new LinkedList<int>();
    public LRUCache(int capacity) {
        this.capacity = capacity;
    }
    
    public int Get(int key) {
        if(map.ContainsKey(key))
        {CustomUpdate(key);
            return map[key];
        }
        else
        {
            return -1;
        }
    }
    
    public void Put(int key, int value) {
        if (map.ContainsKey(key)) {
            map[key] = value;
            CustomUpdate(key);
        } else {
            if (map.Count >= capacity) {
                int oldest = deque.First.Value;
                deque.RemoveFirst();
                map.Remove(oldest);
            }
            map[key] = value;
            deque.AddLast(key);
        }
    }

    private void CustomUpdate(int key) {
        deque.Remove(key);
        deque.AddLast(key);
    }
}