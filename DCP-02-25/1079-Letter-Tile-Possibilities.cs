public class Solution {
    public int NumTilePossibilities(string tiles)
    {
        if (tiles.Length == 1)
        {
            return 1;
        }
        Dictionary<char, int> tileMap = new Dictionary<char, int>();

        foreach (char tile in tiles)
        {
            if (!tileMap.TryAdd(tile, 1))
            {
                tileMap[tile]++;
            }
        }
        int[] tileMapValues = tileMap.Values.ToArray();

        int totalPossibilities = Factorial(tiles.Length);
        foreach (int count in tileMap.Values)
        {
            totalPossibilities /= Factorial(count);
        }
        totalPossibilities += tileMapValues.Length;

        void NumTileHelper(int possibilities, int leftOver, int index)
        {
            if (leftOver == 0)
            {
                totalPossibilities += possibilities;
                return;
            }
            
            if (index == tileMapValues.Length)
            {
                return;
            }

            for (int i = Math.Min(leftOver, tileMapValues[index]); i >= 0; i--)
            {
                NumTileHelper(possibilities / Factorial(i), leftOver - i, index + 1);
            }
        }

        for (int i = tiles.Length - 1; i > 1; i--)
        {
            NumTileHelper(Factorial(i), i, 0);
        }
        
        return totalPossibilities;
    }

    private int Factorial(int n)
    {
        int i = 1;
        
        while (n > 1)
        {
            i *= n--;
        }

        return i;
    }
}