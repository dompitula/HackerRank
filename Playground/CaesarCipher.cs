/*
Julius Caesar protected his confidential information by encrypting it using a cipher. Caesar's cipher shifts each letter by a number of letters.
If the shift takes you past the end of the alphabet, just rotate back to the front of the alphabet.
In the case of a rotation by 3, w, x, y and z would map to z, a, b and c.

Original alphabet:      abcdefghijklmnopqrstuvwxyz
Alphabet rotated +3:    defghijklmnopqrstuvwxyzabc
*/
class CaesarCipher
{

    //  Arguments -
    //  s - string containing a phrase or word
    //  k - integer for how many spaces should the word be ciphered
    //  Returns ciphered string
    public static string caesarCipher(string s, int k)
    {
        char offset;
        string result = "";

        foreach (char c in s)
        {
            if (!char.IsLetter(c)) { result += c; continue; }
            offset = char.IsUpper(c) ? 'A' : 'a';

            result += (char)(((c + k) - offset) % 26 + offset);
        }

        return result;
    }
}

/*class Solution
{
    public static void Main(string[] args)
    {
        string s = "abcdefghijklmnopqrstuvwxyz";

        int k = 2;

        string result = Result.caesarCipher(s, k);

        Console.WriteLine(result);
    }
}*/
