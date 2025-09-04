using System;

class PalindromeCheck
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        string reverse = "";

      
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reverse = reverse + word[i];
        }

      
        if (word.ToLower() == reverse.ToLower())
        {
            Console.WriteLine(word + " is a Palindrome.");
        }
        else
        {
            Console.WriteLine(word + " is NOT a Palindrome.");
        }
    }
}
