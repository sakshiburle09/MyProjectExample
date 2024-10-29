using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    internal class StringManipulation
    {
        public static string Joint(string[] input)
        {
            char c = '~';
            string str = "";
            for (int i = 0; i < input.Length; i++)
            {
                str = str + input[i] + c;
            }
            return str;
        }
        public static string SplitIt(String input)
        {
            string s = "";
            int item = 3;
            string[] st = input.Split('~');
            for (int k = 0; k < st.Length; k++)
            {
                if (k == item)
                {
                    s = s + st[k];
                }
            }
            return s;
        }
        public static string Reverse(string input)
        {
            string st = "";
            string[] s = input.Split(' ');
            for (int j = s.Length - 1; j >= 0; j--)
            {
                st = st + s[j] + " ";
            }
            return st;
        }

        public static string PadLeft(string input1, int n, char a)
        {
            StringBuilder sb = new StringBuilder();
            int n1 = input1.Length - n;
            string s = "";
            for (int i = 0; i <= n1; i++)
            {
                sb.Append(a);
            }
            sb.Append(input1);
            return sb.ToString();
        }
        public static void Main(string[] args)
        {
            string[] input = new string[3];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }
            string output = Joint(input);
            Console.WriteLine(output);

            string s = Console.ReadLine();
            string output1 = SplitIt(s);
            Console.WriteLine(output1);

            string str = Console.ReadLine();
            string output2 = Reverse(str);
            Console.WriteLine(output2);

            string input1 = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            char a = Convert.ToChar(Console.ReadLine());
            string output3 = PadLeft(input1, n, a);
            Console.WriteLine(output3);
            // Console.WriteLine ("Try programiz.pro");
        }
    }
}
