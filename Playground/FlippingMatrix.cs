class FlippingMatrix
{

    /*
     * Complete the 'flippingMatrix' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
     */

    public static int flippingMatrix(List<List<int>> matrix)
    {
        int len = matrix[0].ToArray().GetLength(0);
        int sum = 0;

        for (int i = 0; i < Convert.ToInt32(len / 2); i++)
        {
            for (int j = 0; j < Convert.ToInt32(len / 2); j++)
            {
                sum = sum + Math.Max(matrix[i][j], Math.Max(matrix[i][len - j - 1], Math.Max(matrix[len - i - 1][j], matrix[len - i - 1][len - j - 1])));
            }
        }

        return sum;
    }

}

/*class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> matrix = new List<List<int>>{
            new List<int>(){ 112, 42, 83, 119},
            new List<int>(){ 56, 125, 56, 49},
            new List<int>(){ 15, 78, 101, 43},
            new List<int>(){ 62, 98, 114, 108}
            };
        
        int result = Result.flippingMatrix(matrix);

        Console.WriteLine(result);
    }
}*/
