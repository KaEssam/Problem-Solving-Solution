public class NumberContainers {
    
    private readonly Dictionary<int, int> _indexValues;
    private readonly Dictionary<int, PriorityQueue<int, int>> _valueIndexes;

    public NumberContainers() {
        _indexValues = new();
        _valueIndexes = new(); 
    }
    
    public void Change(int index, int number) {
        _indexValues[index] = number;
        if(!_valueIndexes.ContainsKey(number))
        {
            _valueIndexes.Add(number, new());
        }
        _valueIndexes[number].Enqueue(index, index);
    }
    
    public int Find(int number) {
        if(!_valueIndexes.ContainsKey(number))
        {
            return -1;
        }
        
        while(_valueIndexes[number].Count != 0)
        {
            int index = _valueIndexes[number].Dequeue();
            if(_indexValues[index] == number)
            {
                _valueIndexes[number].Enqueue(index, index);
                return index;
            }
        }

        return -1;
    }
}

/**
 * Your NumberContainers object will be instantiated and called as such:
 * NumberContainers obj = new NumberContainers();
 * obj.Change(index,number);
 * int param_2 = obj.Find(number);
 */