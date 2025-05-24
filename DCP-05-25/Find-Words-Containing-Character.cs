public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        var list = new List<int>();
        for(var i = 0; i < words.Length; i++){
            if(words[i].Contains(x))
                list.Add(i);
        }
        return list;
    }
}