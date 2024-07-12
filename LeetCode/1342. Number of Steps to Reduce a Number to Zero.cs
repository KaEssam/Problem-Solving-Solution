public class Solution {
    public int NumberOfSteps(int num) {
        var steps = 0;
        while (num != 0)
        {
            steps++;
            num = num % 2 == 0 ? num / 2 : num - 1;
        }
        return steps;
    }
}
