using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    public class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("this is base class method");
        }
    }
    public class DrivedClass: BaseClass
    {

        public void show()
        {
            Console.WriteLine("ths is the method of derived class");
        }
    }
    public class InvalidCastExceptionProg
    {
        public static void Main(string[] args)
        {
            try
            {
                // Creating an object of BaseClass
                BaseClass b = new BaseClass();

                // Attempting to cast BaseClass object to DerivedClass
                DrivedClass d = (DrivedClass)b;  // InvalidCastException will occur here

                // If cast succeeds (it won't in this case), this line will be executed
                d.show();
            }
            catch (InvalidCastException ex)
            {
                // Handling the InvalidCastException
                Console.WriteLine("Invalid cast detected. Please check the object type.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
        }
    }
}
