/// <summary>
/// Responsible for checking if given string is palindrome and finding index of faulty character.
/// </summary>
class PalindromeIndex
{
    /// <summary>
    /// Main method that finds index that prevents the string from becoming palindrome.
    /// </summary>
    /// <param name="s"> user given string </param>
    /// <returns> -1, if string is palindrome, faulty index if it blocks the string from
    /// becoming one.
    /// </returns>
    public static int palindromeIndex(string s)
    {
        int start = 0;
        int end = s.Length - 1;

        while (start < end)
        {
            if (s[start] != s[end])
            {
                break;
            }
            start++;
            end--;
        }

        if (start >= end)
        {
            return -1;
        }

        string o1 = new string(s);
        string o2 = new string(s);

        if (IsPalindrome(o1.Remove(start, 1))) { return start; }
        if (IsPalindrome(o2.Remove(end, 1))) { return end; }

        return -1;
    }


    /// <summary>
    /// Responsible for checking if given string is already a palindrome.
    /// </summary>
    /// <param name="s"> user given string </param>
    /// <returns> True, if string is a palindrome. Otherwise, False. </returns>
    public static bool IsPalindrome(string s)
    {
        char[] reversedS = s.ToCharArray();
        Array.Reverse(reversedS);
        string reversed = new string(reversedS);

        return s == reversed;
    }
}

/*class Solution
{
    public static void Main(string[] args)
    {
        string s1 = "aaab";
        string s = "hgygsvlfcwnswtuhmyaljkqlqjjqlqkjlaymhutwsnwcwflvsgygh";

        int result = PalindromeIndex.palindromeIndex(s);

        Console.WriteLine(result);
    }
}*/
