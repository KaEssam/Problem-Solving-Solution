/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return \t     -1 if num is higher than the picked number
 *\t\t\t      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        var left = 1;
        var right = n;

        while(left <= right) {
            
            var mid = left + (right - left) / 2;
            var guessNumber = guess(mid);
            
            if(guessNumber == 0) return mid;
            else if(guessNumber == -1) right = mid - 1;
            else if(guessNumber == 1) left = mid + 1;
        }

        return default;
    }
}