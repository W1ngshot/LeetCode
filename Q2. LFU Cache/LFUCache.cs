namespace LeetCode.Q2._LFU_Cache;

public class LFUCache(int capacity)
{
    private readonly Dictionary<int, LinkedListNode<(int Key, int Value, int Frequency)>> _cache = new();

    private readonly Dictionary<int, LinkedListNode<(int Key, int Value, int Frequency)>> _lastAccessedByFrequency =
        new();

    private readonly LinkedList<(int Key, int Value, int Frequency)> _list = [];

    private const int NewNodeFrequency = 1;

    public int Get(int key)
    {
        if (!_cache.TryGetValue(key, out var node))
            return -1;

        var newNode = new LinkedListNode<(int Key, int Value, int Frequency)>(
            (node.Value.Key, node.Value.Value, node.Value.Frequency + 1));

        MoveNode(node, newNode);

        return node.Value.Value;
    }

    public void Put(int key, int value)
    {
        if (!_cache.TryGetValue(key, out var node))
        {
            if (_list.Count == capacity)
            {
                _cache.Remove(_list.First!.Value.Key, out var removedNode);
                _list.RemoveFirst();

                if (_lastAccessedByFrequency.TryGetValue(removedNode!.Value.Frequency, out var prevNode)
                    && prevNode == removedNode)
                    _lastAccessedByFrequency.Remove(prevNode.Value.Frequency);
            }

            var addNode = new LinkedListNode<(int Key, int Value, int Frequency)>((key, value, NewNodeFrequency));

            if (_lastAccessedByFrequency.TryGetValue(NewNodeFrequency, out var existingNode))
            {
                _lastAccessedByFrequency[NewNodeFrequency] = addNode;
                _list.AddAfter(existingNode, addNode);
                _cache.Add(key, addNode);

                return;
            }

            _lastAccessedByFrequency[NewNodeFrequency] = addNode;
            _list.AddFirst(addNode);
            _cache.Add(key, addNode);

            return;
        }

        var newNode = new LinkedListNode<(int Key, int Value, int Frequency)>(
            (node.Value.Key, value, node.Value.Frequency + 1));

        MoveNode(node, newNode);
    }

    private void MoveNode(LinkedListNode<(int Key, int Value, int Frequency)> node,
        LinkedListNode<(int Key, int Value, int Frequency)> newNode)
    {
        var nodePrevious = node.Previous;
        _list.Remove(node);


        if (_lastAccessedByFrequency[node.Value.Frequency] == node)
        {
            if (nodePrevious?.Value.Frequency == node.Value.Frequency)
                _lastAccessedByFrequency[node.Value.Frequency] = nodePrevious;
            else
                _lastAccessedByFrequency.Remove(node.Value.Frequency);
        }

        if (!_lastAccessedByFrequency.TryGetValue(node.Value.Frequency + 1, out var prevNode))
        {
            _lastAccessedByFrequency.Add(node.Value.Frequency + 1, newNode);

            if (!_lastAccessedByFrequency.TryGetValue(node.Value.Frequency, out var lastNode))
            {
                if (nodePrevious is null)
                {
                    _list.AddFirst(newNode);
                }
                else
                    _list.AddAfter(nodePrevious, newNode);

                _cache[node.Value.Key] = newNode;
                return;
            }

            _list.AddAfter(lastNode, newNode);
            _cache[node.Value.Key] = newNode;
            return;
        }

        _lastAccessedByFrequency[node.Value.Frequency + 1] = newNode;
        _list.AddAfter(prevNode, newNode);
        _cache[node.Value.Key] = newNode;
    }
}

/*
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */