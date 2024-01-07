using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatr
{
    public interface IOperator
    {
        double Calculate(double num1, double num2);
    }
    public class Add : IOperator
    {
        public double Calculate(double num1, double num2)
        {
            return num1+num2;
        }
    }
    public class Subtract : IOperator
    {
        public double Calculate(double num1, double num2)
        {
            return num1-num2;
        }
    }
    public class Multiply : IOperator
    {
        public double Calculate(double num1, double num2)
        {
            return num1*num2;
        }
    }
    public class Divide : IOperator
    {
        public double Calculate(double num1, double num2)
        {
            try
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero!");
                }
                return num1/num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }

        }
    }
}
