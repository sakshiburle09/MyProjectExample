using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    public class OddLetter
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a word");
            string w = Console.ReadLine();

            string space = "";

            for (int i = 0; i<w.Length; i++)
            {
                if (i%2==0)
                {
                    space = space + char.ToUpper(w[i]);
                }
                else
                {
                    space = space + char.ToLower(w[i]);
                }
            }
            Console.Write(space);
        }
    }
}
