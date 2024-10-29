using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    internal class NullReferenceExceptionProg
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a string: ");
                string str = Console.ReadLine();

                // Simulate a NullReferenceException for the example
                if (string.IsNullOrEmpty(str))
                {
                    str = null; // Manually setting the string to null for demonstration
                }

                // Attempting to access the length of a null string
                Console.WriteLine("Length of the string is: " + str.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null reference encountered. Please provide a valid string.");
            }
        }
    }
}
