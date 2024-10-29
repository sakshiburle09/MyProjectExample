using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    public class Operation
    {
        internal double Num1 { get; set; }
        internal double Num2 { get; set; }
        internal char opr { get; set; }

        public Operation(double num1, double num2, char op)
        {
            num1 = Num1;
            num2 = Num2;
            op = opr;
        }
    }

    public class Source
    {
        public string ExceptionHandle(Operation o)
        {
            try
            {
                if (o.opr != '+' && o.opr != '-' && o.opr != '*' && o.opr != '/')
                {
                    throw new Exception("Invalid Operator");
                }
                if (o.opr == '/' && o.Num2 == 0)
                {
                    throw new DivideByZeroException("Divided By Zero is not allowed");
                }
                return "No Exeption found";
            }
            catch (DivideByZeroException ex)
            {
                return ex.Message;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string Calculator(Operation o)
        {
            try
            {
                switch (o.opr)
                {
                    case '+':
                        Console.WriteLine((o.Num1 + o.Num2).ToString());
                        break;

                    case '-':
                        Console.WriteLine((o.Num1 - o.Num2).ToString());
                        break;

                    case '*':
                        Console.WriteLine((o.Num1 * o.Num2).ToString());
                        break;

                    case '/':
                        if (o.Num2 == 0)
                        {
                            throw new DivideByZeroException("Divide By Zero Exception");
                        }
                        return (o.Num1 / o.Num2).ToString();
                        break;

                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                return ex.Message;
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";
        }

    }
    public class Program1
    {
        public static void Main(string[] args)
        {
            
            Operation opp = new Operation(15, 0, '/');
            Source source = new Source();
            Console.WriteLine(source.ExceptionHandle(opp));
            Console.WriteLine(source.Calculator(opp));
        }
    }
}
