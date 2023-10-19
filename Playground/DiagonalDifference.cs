/*
Given a square matrix, calculate the absolute difference between the sums of its diagonals.
*/

class DiagonalDifference
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            int left = arr[i][i];
            int right = arr[i][arr.Count - 1 - i];

            leftSum = leftSum + left;
            rightSum = rightSum + right;
        }

        return Math.Abs(leftSum - rightSum);
    }

}

/*class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>{
            new List<int>(){ 1, 2, 3},
            new List<int>(){ 4, 5, 6},
            new List<int>(){ 9, 8, 9}
        };

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);
    }
}*/
