using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    internal class ArrayIndexOutofRangeProg
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[] { 1, 2, 3, 4 };
                Console.Write("arr= {");
                for(int i =0; i<arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("}");
                Console.Write("Index:");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.Write(arr[index]);
                Console.WriteLine();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Write("Index out of range. please enter a valid index");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Invalid input. please enter valid number");
            }
        }
    }
}
