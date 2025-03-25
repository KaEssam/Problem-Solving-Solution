public class Solution {
     bool check((int, int)[] a, int i, int k)
 {
     int r = a[i].Item2;
     while (i < a.Length && a[i].Item1 < r)
         r = Math.Max(r, a[i++].Item2);

     return i < a.Length && (k == 1 || check(a, i, k - 1));

 }
 public bool CheckValidCuts(int n, int[][] rectangles)
 {
     var a = rectangles.Select(x => (x[0], x[2])).OrderBy(x => x.Item1).ToArray();
     var b = rectangles.Select(x => (x[1], x[3])).OrderBy(x => x.Item1).ToArray();
     return check(a, 0, 2) || check(b, 0, 2);
 }
}