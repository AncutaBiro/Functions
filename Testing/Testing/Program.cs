using System;

namespace Testing
{
    class Program
    {

        static void Main(string[] args)
        {
            string text = "This is test phrase.";
                Console.WriteLine(findWord(text, "this", true));
            
            Console.Read();
        }

        static bool findWord(string text, string word, bool casesensitive = false)
        {

            string[] words = text.Split(' ', ',', '.', '!', '?');

            for (int i = 0; i < words.Length; i++)
            {
                bool bFound = casesensitive ?
                    words[i].Equals(word) :
                    words[i].Equals(word, StringComparison.CurrentCultureIgnoreCase);

                if (bFound)
                    return true;
            }
            return false;
        }


    }
}

