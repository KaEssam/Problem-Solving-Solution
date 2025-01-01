class Solution {
public:
    bool isAnagram(string s, string t) {

        if (s.length() != t.length())
        return false;

        std::string sSorted = s;
        std::string tSorted = t;

        std::sort(sSorted.begin(), sSorted.end());
        std::sort(tSorted.begin(), tSorted.end());

        return sSorted == tSorted;
    }
};