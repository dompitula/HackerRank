/*The median of a list of numbers is essentially its middle element after sorting. The same number of
elements occur after it as before. Given a list of numbers with an odd number of elements, find the median?*/

class Median
{

    /*
     * Complete the 'findMedian' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int findMedian(List<int> arr)
    {
        arr.Sort();
        int odd = (arr.Count) / 2;
        int even = ((arr.Count - 1 / 2) + (arr.Count / 2));

        if (arr.Count % 2 != 0) { return arr[odd]; }
        else { return arr[even]; }
    }

}

/*class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = new List<int> { 0, 1, 2, 5, 4, 3, 6 };

        int result = Result.findMedian(arr);

        Console.WriteLine(result);
    }
}*/
