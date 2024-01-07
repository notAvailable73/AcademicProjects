using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatr
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            IOperator operate;
            switch (choice)
            {
                case 1:
                    operate = new Add(); 
                    break;
                case 2:
                    operate = new Subtract();
                    break;
                case 3:
                    operate = new Multiply();
                    break;
                case 4:
                    operate = new Divide();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            double result = operate.Calculate(num1,num2);
            Console.WriteLine($"Result: {result}");
        }

       
    }

}
