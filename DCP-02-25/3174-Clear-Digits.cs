public class Solution {
    public string ClearDigits(string s) {
        string dupe = "";

        foreach(char ch in s){
            if(char.IsDigit(ch)){
                if(dupe.Length >0){
                    dupe = dupe.Remove(dupe.Length-1);
                }
            }
            else{
                dupe += ch;
            }
        }
        return dupe;
        
    }
}