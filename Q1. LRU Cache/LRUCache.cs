namespace LeetCode.Q1._LRU_Cache;

public class LRUCache(int capacity)
{
    private readonly Dictionary<int, LinkedListNode<(int Key, int Value)>> _cache = new();
    private readonly LinkedList<(int Key, int Value)> _list = [];

    public int Get(int key) {
        if (!_cache.TryGetValue(key, out var node)) 
            return -1;
        
        
        _list.Remove(node);
        _list.AddLast(node);

        return node.Value.Value;
    }
    
    public void Put(int key, int value) {
        
        if (!_cache.TryGetValue(key, out var node))
        {
            if (_list.Count == capacity)
            {
                _cache.Remove(_list.First!.Value.Key);
                _list.RemoveFirst();
            }

            var addNode = new LinkedListNode<(int Key, int Value)>((key, value));
            _cache.Add(key, addNode);
            _list.AddLast(addNode);
            return;
        }

        _list.Remove(node);
        _cache.Remove(key);

        var newNode = new LinkedListNode<(int Key, int Value)>((key, value));
        _list.AddLast(newNode);
        _cache.Add(key, newNode);
    }
}

/*
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */