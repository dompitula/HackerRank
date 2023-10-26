/// <summary>
/// Finds super digit of any given number.
/// </summary>
class SuperDigit
{
    /// <summary>
    /// Adds individual digits together until there's only one left.
    /// </summary>
    /// <param name="n"> Number given in string. </param>
    /// <param name="k"> How many times to multiply initial number. </param>
    /// <returns> Final single super digit. </returns>
    public static int superDigit(string n, int k)
    {
        int sum = 0;

        foreach (char c in n)
        {
            sum += (int)Char.GetNumericValue(c);
        }

        sum *= k;

        if (sum.ToString().Length == 1)
        {
            return sum;
        }
        else
        {
            return superDigit(sum.ToString(), 1);
        }
    }

}

/*class Solution
{
    public static void Main(string[] args)
    {
        string n = "9875";

        int k = 4;

        int result = SuperDigit.superDigit(n, k);

        Console.WriteLine(result);
    }
}*/
