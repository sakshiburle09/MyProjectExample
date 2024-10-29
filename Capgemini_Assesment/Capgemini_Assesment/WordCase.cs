using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    public class WordCase
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            Console.WriteLine("select your choice \n 1. convert to upper case \n 2.convert to lower case");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Upper case: " + s.ToUpper());
                    break;
                case 2:
                    Console.WriteLine("lower case: " + s.ToLower());
                    break;
                default:
                    Console.WriteLine("Please enter correct choice");
                    break;
            }
            
        }
    }
}
