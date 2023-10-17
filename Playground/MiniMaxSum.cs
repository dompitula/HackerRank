/*
Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
Then print the respective minimum and maximum values as a single line of two space-separated long integers.
*/

class MiniMaxSum
{
    public static void miniMaxSum(List<int> arr)
    {
        ulong sumMin = ulong.MaxValue;
        ulong sumMax = ulong.MinValue;

        for (int i = 0; i < arr.Count; i++)
        {
            ulong sum = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                if (arr[j] != arr[i]) { sum = sum + Convert.ToUInt64(arr[j]); }
            }
            if (sum < sumMin) { sumMin = sum; }
            if (sum > sumMax) { sumMax = sum; }
        }

        if (sumMax == 0 && sumMin == 0)
        {
            for (int j = 1; j < arr.Count; j++)
            {
                sumMin = sumMin + Convert.ToUInt64(arr[1]);
                sumMax = sumMin;
            }
        }
        Console.WriteLine("min: {0}", sumMin);
        Console.WriteLine("max: {0}", sumMax);
    }

}

/*class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = new List<int> { 1, 2, 3, 4, 5 };
        List<int> arr1 = new List<int> { 5, 5, 5, 5, 5 };

        Result.miniMaxSum(arr);
    }
}*/
