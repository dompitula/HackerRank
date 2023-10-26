/// <summary>
/// Sort grid rows alphabetically, and check if all rows and columns are in alphabetical order.
/// </summary>
class GridChallenge
{
    /// <summary>
    /// Checks if all rows and columns are in alphabetical order.
    /// </summary>
    /// <param name="grid"> user given grid </param>
    /// <returns> "YES", if all rows and columns are in alphabetical order.
    /// Otherwise, "NO". </returns>
    public static string gridChallenge(List<string> grid)
    {
        string column = string.Empty;
        string columnR = string.Empty;

        for (int i = 0; i < grid.Count; i++)
        {
            grid[i] = SortString(grid[i]);
        }

        for (int i = 0; i < grid[0].Length; i++)
        {
            for (int j = 0; j < grid.Count; j++)
            {
                column += grid[j][i];
                columnR = SortString(column);
            }

            if (column != columnR) { return "NO"; }

            column = columnR = String.Empty;
        }

        return "YES";
    }

    /// <summary>
    /// Sorts strings alphabetically.
    /// </summary>
    /// <param name="str"> String to sort alphabetically. </param>
    /// <returns> Alphabetically sorted string. </returns>
    public static string SortString(string str)
    {
        char[] characters = str.ToArray();
        Array.Sort(characters);

        return new string(characters);
    }
}

/*class Solution
{
    public static void Main(string[] args)
    {
        List<string> grid = new List<string>()
        {
            "mpxz",
            "abcd",
            "wlmf"
        };

        string result = GridChallenge.gridChallenge(grid);

        Console.WriteLine(result);
    }
}*/
