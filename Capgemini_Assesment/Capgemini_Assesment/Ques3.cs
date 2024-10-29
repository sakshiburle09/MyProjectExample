using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    public class Ques3
    {
        public static void Main(string[] args)
        {
            int outer = 1;
            do
            {
                int inner = 1;
                do
                {
                    Console.WriteLine(outer + " " + inner);
                    inner++;
                } while (inner <= 2);
                outer++;
            } while (outer <= 5);
            

        }
    }

}

