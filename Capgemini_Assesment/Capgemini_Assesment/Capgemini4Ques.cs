using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    // Online C# Editor for free
    // Write, Edit and Run your C# code using C# Online Compiler

    using System;
    using System.Reflection;
    interface InterfaceA
    {
        void InterfaceMethod();
    }

    class Sample : InterfaceA
    {
        public Sample()
        {

        }
        public void InterfaceMethod()
        {
            Console.WriteLine("Printed from sample class");
        }
    }

    class Verification
    {
        public bool CheckInterfaceImplemented(string interfaceName)
        {
            Type type = typeof(Sample);
            Type[] interfaces = type.GetInterfaces();
            foreach (Type iface in interfaces)
            {
                if (iface.Name == interfaceName)
                {
                    return true;
                }
            }
            return false;

        }
        public bool CheckIfConstructorExists(string constructorName)
        {
            Type type = typeof(Sample);
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                if (constructor.Name == constructorName || constructor.ToString().Contains(constructorName))
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckIfMethodExists(string methodName)
        {
            Type type = typeof(Sample);
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                if (method.Name == methodName)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Capgemini4Ques
    {
        public static void Main(string[] args)
        {
            var verification = new Verification();

            var result = verification.CheckIfConstructorExists("Void.ctor");
            Console.WriteLine(result);

            result = verification.CheckIfMethodExists("InterfaceMethod");
            Console.WriteLine(result);

            result = verification.CheckInterfaceImplemented("InterfaceA");
            Console.WriteLine(result);
        }
    }
}
