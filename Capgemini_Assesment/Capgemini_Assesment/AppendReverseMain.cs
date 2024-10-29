using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    // Online C# Editor for free
    // Write, Edit and Run your C# code using C# Online Compiler
    using System.Text;
    using System;

    public class AppendAndReverse
    {

        public StringBuilder FindExponential(int number)
        {
            StringBuilder s = new StringBuilder("Exponential is ");
            double res = Math.Exp(number);
            s.Append(res);
            return s;
        }
        public string ReplaceWord(string sentence, string word1, string word2)
        {
            if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
            {
                return sentence;
            }
            return sentence.Replace(word1, word2);
        }
    }
    public class AppendReverseMain
    {
        public static void Main(string[] args)
        {
            AppendAndReverse obj = new AppendAndReverse();

            Console.Write("enter a number to check exponential: ");
            int number = Convert.ToInt32(Console.ReadLine());

            StringBuilder result = obj.FindExponential(number);

            Console.Write("Enter a sentance:");
            string sentence = Console.ReadLine();

            Console.Write("enter first word:");
            string word1 = Console.ReadLine();

            Console.Write("enter secound word:");
            string word2 = Console.ReadLine();

            string res1 = obj.ReplaceWord(sentence, word1, word2);

            Console.WriteLine("result of exponential method: " + result);
            Console.WriteLine("result of ReplaceWOrd method: " + res1);
        }
    }
}
