using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    public class SourceClass
    {
        public int Add(int a)
        {
            a += 3;
            return a;
        }
        public int Add(out int a)
        {
            a = 30;
            return a + 3;
        }
        public int Add(int a, int b)
        {
            return (a + b);
        }
        public string Add(int a, int b, string msg)
        {
            int res = a + b;
            return (res + msg);
        }
        public static void Main(string[] args)
        {
            //Console.Write("a = ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b = ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("message = ");
            //string msg = Console.ReadLine();    
            //SourceClass sc = new SourceClass();
            //Console.WriteLine(sc.Add(a));
            //Console.WriteLine(sc.Add(out a));
            //Console.WriteLine(sc.Add(a,b));
            //Console.WriteLine(sc.Add(a, b, msg));





            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a;
            string msg = Console.ReadLine();

            SourceClass obj = new SourceClass();
            //obj.Add(a);
            Console.WriteLine(obj.Add(a));
            //i//nt a;
            Console.WriteLine(obj.Add(out a));
            Console.WriteLine(obj.Add(c, b));
            Console.WriteLine(obj.Add(c, b, msg));

        }
    }
}
