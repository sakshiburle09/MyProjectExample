using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    public class StringBuilderUsingInsert
    {
        public StringBuilder WordInserting(StringBuilder word1, char ch, string word2)
        {
            int index = word1.ToString().IndexOf(ch);
            if (index != -1)
            {
                word1.Insert(index, word2);
            }

            return word1;
        }

        public static void Main(string[] args)
        {
            StringBuilderUsingInsert p = new StringBuilderUsingInsert();

            Console.WriteLine("enter a word1");
            StringBuilder word1 = new StringBuilder(Console.ReadLine());


            Console.WriteLine("enter a searching element");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enter a word2");
            string word2 = Console.ReadLine();

            var result = p.WordInserting(word1, ch, word2);
            Console.WriteLine(result.ToString());
        }

    }
}

