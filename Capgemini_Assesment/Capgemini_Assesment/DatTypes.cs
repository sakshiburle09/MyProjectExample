using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    public class DatTypes
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENter a float value:");
            float f = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter a duoble value:");
             double d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a long value:");
            long l = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter a string value");
            string s = Convert.ToString(Console.ReadLine());

            Console.WriteLine("int: " + a);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("long: "+l);
            //Console.WriteLine("string " + s);
        }
    }
}
