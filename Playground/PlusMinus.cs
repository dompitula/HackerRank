class PlusMinus
{
    public static void plusMinus(List<int> arr)
    {
        decimal positiveCount = 0;
        decimal negativeCount = 0;
        decimal neutralCount = 0;


        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > 0) { positiveCount++; }
            else if (arr[i] < 0) { negativeCount++; }
            else { neutralCount++; }
        }

        Console.WriteLine((positiveCount / arr.Count).ToString("N6"));
        Console.WriteLine((negativeCount / arr.Count).ToString("N6"));
        Console.WriteLine((neutralCount / arr.Count).ToString("N6"));

    }

}

/*class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };

        Result.plusMinus(arr);
    }
}*/
