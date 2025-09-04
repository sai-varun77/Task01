using System;

class AnagramCheck
{
    static void Main()
    {
        Console.Write("Enter first word: ");
        string word1 = Console.ReadLine().ToLower();
        Console.Write("Enter second word: ");
        string word2 = Console.ReadLine().ToLower();

        
        if (word1.Length != word2.Length)
        {
            Console.WriteLine("The words are NOT Anagrams.");
            return;
        }

       
        char[] arr1 = word1.ToCharArray();
        char[] arr2 = word2.ToCharArray();

      
        for (int i = 0; i < arr1.Length - 1; i++)
        {
            for (int j = i + 1; j < arr1.Length; j++)
            {
                if (arr1[i] > arr1[j])
                {
                    char temp = arr1[i];
                    arr1[i] = arr1[j];
                    arr1[j] = temp;
                }
                if (arr2[i] > arr2[j])
                {
                    char temp = arr2[i];
                    arr2[i] = arr2[j];
                    arr2[j] = temp;
                }
            }
        }

        string sorted1 = new string(arr1);
        string sorted2 = new string(arr2);

       
        if (sorted1 == sorted2)
        {
            Console.WriteLine("The words are Anagrams.");
        }
        else
        {
            Console.WriteLine("The words are NOT Anagrams.");
        }
    }
}
