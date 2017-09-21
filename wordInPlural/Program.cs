using System;

namespace wordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string wordTrim = "";
            string wordAdd = "";

            if (word.EndsWith("y"))
            {
                wordTrim = word.TrimEnd('y');
                wordAdd = wordTrim + "ies";
            }
            else if (word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z"))                   
            {
                wordTrim = word.Remove(word.Length - 1);
                wordAdd = wordTrim + "es";
            }
            else if (word.EndsWith("ch") || word.EndsWith("sh"))
            {
                wordTrim = word.Remove(word.Length - 2);
                wordAdd = wordTrim + "es";
            }
            else
            {
                wordAdd = word + "s";
            }
            Console.WriteLine(wordAdd);
        }
    }
}
