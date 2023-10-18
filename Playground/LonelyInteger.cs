/*
Given an array of integers, where all elements but one occur twice, find the unique element.
*/

class LonelyInteger
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {
        int count = 0;
        for (int i = 0; i < a.Count; i++)
        {
            for (int j = 0; j < a.Count; j++)
            {
                if (a[i] == a[j])
                {
                    count = count + 1;
                }
            }
            if (count == 1)
            {
                return a[i];
            }

            count = 0;
        }

        return 0;
    }

}

/*class Solution
{
    public static void Main(string[] args)
    {
        List<int> a = new List<int> { 1, 2, 3, 4, 3, 2, 1 };

        int result = Result.lonelyinteger(a);

        Console.WriteLine(result);
    }
}*/
