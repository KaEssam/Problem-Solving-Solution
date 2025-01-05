public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {

        List<string> result = new List<string>();
    
        foreach (var word in words)
        {
            if (MatchPattern(word, pattern))
            {
                result.Add(word);
            }
        }
        
        return result;
    }

    bool MatchPattern(string word, string pattern)
    {      
        Dictionary<char, char> DicWord = new Dictionary<char, char>();
        Dictionary<char, char> DicPattern = new Dictionary<char, char>();
        
        for (int i = 0; i < word.Length; i++)
        {
            char p = pattern[i];
            char w = word[i];
            
            if (DicWord.ContainsKey(p))
            {
                if (DicWord[p] != w)
                {
                    return false;
                }
            }
            else
            {
                DicWord[p] = w;
            }
            
            if (DicPattern.ContainsKey(w))
            {
                if (DicPattern[w] != p)
                {
                    return false; 
                }
            }
            else
            {
                DicPattern[w] = p;
            }
        }
        
        return true; 
    }
}